using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uvozovky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Visible = false;
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
            InitializeComponent();
        }

        private void dolni_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dolni_Click(object sender, EventArgs e)
        {
            SendKeys.Send("%{TAB}");
            Thread.Sleep(100);
            SendKeys.Send("„");
        }

        private void horni_Click(object sender, EventArgs e)
        {
            SendKeys.Send("%{TAB}");
            Thread.Sleep(100);
            SendKeys.Send("“");
        }
    }
}
