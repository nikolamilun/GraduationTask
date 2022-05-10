using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraduationTask
{
    public partial class ServerName : Form
    {
        public string srvName;
        public ServerName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            srvName = txtSrvName.Text;
            Close();
        }
    }
}
