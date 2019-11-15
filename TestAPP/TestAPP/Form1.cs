using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "dev3 change";
            label2.Text = "master dev3 changes";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("initCom");
            label1.Text = "dev3 change";
            label2.Text = "initComEDITED WITH AMEND 1 2";
            label3.Text = "changes from master"; //test
            label1.Text = "master changes";
            //dev5 test
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("call from master main  window");
        }
    }
}
