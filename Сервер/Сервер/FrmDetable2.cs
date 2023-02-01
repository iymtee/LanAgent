using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сервер
{
    public partial class FrmDetable2 : Form
    {
        public FrmDetable2()
        {
            InitializeComponent();
        }

        private void FrmDetable2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // отменить закрытие формы с детальной информацией
            this.Hide();



        }
    }
}
