using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextReg
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey regkey= Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("TestReg");
            int? count = (int?)regkey.GetValue("Count");
            if (count== null) { count = 10; }
            count--;
            regkey.SetValue("Count", count);
            if (count > 0) { regkey.SetValue("Count", count); }
            else { MessageBox.Show("Лимит исчерпан!!");button1.Enabled = false; }
            //if (regkey == null)
            //{
            //    regkey = Registry.LocalMachine.CreateSubKey("SOFTWARE").CreateSubKey("TestReg");
            //}
            //regkey.SetValue("test", "Проверяем!!");
            regkey.Close();

        }

    }
}
