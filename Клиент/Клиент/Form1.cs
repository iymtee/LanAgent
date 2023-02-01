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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
namespace Клиент
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        byte[] StructToByte(info comp)
        {
            BinaryFormatter bf = new BinaryFormatter(); // сериализатор
            MemoryStream ms = new MemoryStream(); // поток в ОЗУ
            bf.Serialize(ms, comp); // выполнить сериализацию
            return ms.ToArray(); // преобразовать поток в массив байт
        }
       void Connect(string ipserver, int port, info comp)
        {
            try
            {
                // создать объект для взаимодействия с сервером
                TcpClient client = new TcpClient(ipserver, port);
                // создать поток для подключения к указанному серверу
                NetworkStream stream = client.GetStream();
                // преобразовать структуру в массив байт
                byte[] data = StructToByte(comp);
                // вывести все данные из массива в поток (отправить на сервер)
                stream.Write(data, 0, data.Length);
                // закрыть поток к подключение к серверу
                stream.Close();
                client.Close();

                tslStatus.Text = DateTime.Now.ToShortTimeString() + " данные на сервер успешно отправлены";
            }
            catch
            {
                tslStatus.Text = DateTime.Now.ToShortTimeString() + " ошибка отправки данных на сервер";
            }
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            int tm = 0;
            if (tbxTime.Text != "") tm = Convert.ToInt32(tbxTime.Text);
            if(tm > 0) timer1.Interval = tm * 60000;
            else timer1.Enabled = false;

            timer1_Tick(sender,e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            info comp;
            comp.username = Environment.UserName; // имя пользователя
            comp.netname = Environment.MachineName; // имя компьютера
            comp.ip = Dns.GetHostByName(Environment.MachineName).AddressList[0].ToString(); ; // ip адрес
            comp.dt = DateTime.Now;

            Bitmap bmp = new Bitmap
               (Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics gr = Graphics.FromImage(bmp);
            gr.CopyFromScreen(0, 0, 0, 0, bmp.Size);
            comp.scr = bmp;

            comp.allDrivers = DriveInfo.GetDrives(); // информация о логических дисках

            Process[] prc = Process.GetProcesses(); // получить список процессов
            string[] strprc = new string[prc.Length]; // строки со списком процессов
            
            for (int i = 0; i <= prc.Length - 1; i++)
                strprc[i] = prc[i].ProcessName + "||" + prc[i].PrivateMemorySize64 / 1024;
            comp.process = strprc;

            int port = Convert.ToInt32(tbxPort.Text);
            Connect(tbxAdress.Text, port, comp);

        }
    }
}
