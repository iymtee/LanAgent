using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DllStruct;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Net.Sockets;
using Microsoft.Win32;
namespace Сервер
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        TcpListener server = null; // обьект для сервера 
        Thread th1; // обьект для потока;
        
        string addr = "127.0.0.1";
        int port = 9595;
        bool autostart = false;
        int delday = 3;
        int delcnt = 20;
        // список для хранения данных, полученных от клиентов
        List<info> lstinfo = new List<info>();

        FrmDetable2 frmDetal = new FrmDetable2();
         
        void SaveSettings()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\LanAgentServer");

            key.SetValue("Addres", addr);
            key.SetValue("Port", port);
            key.SetValue("Autostart", autostart);
            key.SetValue("DelDay", delday);            
            key.SetValue("DelCnt", delcnt);            

            key.Close();
        }

        void SetAutoRun(string name, bool autorun)
        {
            string exe = Application.ExecutablePath;
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");

            try
            {
                if (autorun)
                    key.SetValue(name, "\"" + exe + "\"" + " /min");
                else key.DeleteValue(name);

            }
            catch { }
            key.Close();
        }        

        info ByteToStruct(byte[] data)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();

            ms.Write(data, 0, data.Length);
            ms.Seek(0, SeekOrigin.Begin);

            return (info)bf.Deserialize(ms);
        }

        void WorkServer(object server)
        {
            while (true)
            {
                byte[] buf = new byte[7000000];
                TcpClient client = (server as TcpListener).AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                
                int countbyte;
                while ((countbyte = stream.Read(buf, 0, buf.Length)) != 0) ;
                
                info comp = ByteToStruct(buf);

                stream.Read(buf, 0, buf.Length);

                Invoke(new MethodInvoker(delegate
                {
                    lstinfo.Add(comp);
                    dgvInfo.Rows.Add(comp.ip, comp.netname, comp.dt);
                }));
                stream.Close();
                client.Close();
            }

        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSetting1 frm = new FrmSetting1();

            frm.tbxAdress.Text = addr;
            frm.tbxPort.Text = port.ToString();
            frm.tbxDelDay.Text = delday.ToString();
            frm.tbxDelCnt.Text = delcnt.ToString();
            frm.chkAutoRun.Checked = autostart;

            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            frm.chkAutoRun.Checked = key.GetValue("LanAgentServer") != null;


            if(frm.ShowDialog() == DialogResult.OK)
            {
                addr = frm.tbxAdress.Text;
                port = Convert.ToInt32(frm.tbxPort.Text);
                delday = Convert.ToInt32(frm.tbxDelDay.Text);
                delcnt = Convert.ToInt32(frm.tbxDelCnt.Text);
                autostart = frm.chkAutoStart.Checked;
                frm.ShowDialog();

                SetAutoRun("LanAgentServer", frm.chkAutoRun.Checked);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RegistryKey k = Registry.CurrentUser.OpenSubKey(@"Software\LanAgentServer");

            if (k != null)
            {
                addr = (string)k.GetValue("Addres");
                port = (int)k.GetValue("Port");
                delday = (int)k.GetValue("DelDay");
                delcnt = (int)k.GetValue("DelCnt");
                autostart = Convert.ToBoolean(k.GetValue("Autostart"));
            }
            else SaveSettings();

            if (autostart) btnStartServ_Click(sender,e);
        }

        private void btnStartServ_Click(object sender, EventArgs e)
        {
            // создать обьект клиента TCPListener для сервера
            server = new TcpListener(IPAddress.Parse(addr), port);
            server.Start();

            th1 = new Thread(WorkServer);
            th1.Start(server);
            tslInfo.Text = "Сервер запущен";
        }

        private void btnStopServ_Click(object sender, EventArgs e)
        {
            th1.Abort();
            server.Stop();
            tslInfo.Text = "Сервер остановлен";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // если поток для обработки запросов клиентов существует, ...
            if( th1 != null)
            {
                // если поток работает, то прервать его
                if (th1.IsAlive) th1.Abort();
                // остановить сервер
                server.Stop();
            }
        }

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n= e.RowIndex; // номер строки, на которой выполнен щелчок

            if (n < 0) return;

            frmDetal.lblUserName.Text = lstinfo[n].username;
            frmDetal.lblNetName.Text = lstinfo[n].netname;
            frmDetal.lblDateTime.Text = lstinfo[n].dt.ToString();
            frmDetal.lblIp.Text = lstinfo[n].ip;

            frmDetal.tbxProcess.Lines = lstinfo[n].process;
            frmDetal.pbcScr.Image = lstinfo[n].scr;

            frmDetal.tbxDrive.Clear();
            DriveInfo[] drv = lstinfo[n].allDrivers;

            foreach (DriveInfo d in drv)
            {
                frmDetal.tbxDrive.Text += "Диск " + d.Name + "\r\n     Тип диска " + d.DriveType;
                if (d.IsReady)
                {
                    frmDetal.tbxDrive.Text += "\r\n     Файловая система" + d.DriveFormat + "\r\n     Метка диска " + d.VolumeLabel + "\r\n     Обьем диска " + d.TotalSize +
                        "\r\nСвободно " + d.TotalFreeSpace+"\r\n\r\n";
                }
            }
        }

        private void dgvInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDetal.Show();
        }
    }
}
