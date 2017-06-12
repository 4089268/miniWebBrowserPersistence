using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class inputText : Form
    {
        string url = "";
        public inputText()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            url = "";            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            url = tb1.Text;
            this.Close();
        }

        public String mostrar()
        {
            this.ShowDialog();
            return url;
        }
    }
}
