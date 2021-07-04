using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading;


namespace Santino_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void at_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void ad_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void In_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void ac_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Ir_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.mx");
        }
    }
}
