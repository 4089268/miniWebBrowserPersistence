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
    public partial class Form1 : Form {
        Boolean x = true;
        Boolean StipVisible = true;

        public Form1() {
           InitializeComponent();
           this.TopMost = true;              
           
           webBrowser1.Navigate("https://www.google.com/");                 
        }

        private void ts_label1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            if (x) {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                this.toolStripButton1.Image = global::WebBrowser.Properties.Resources.unlock;
                x = !x;
            }
            else {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.toolStripButton1.Image = global::WebBrowser.Properties.Resources._lock;
                x = !x;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e) {
            inputText form = new inputText();
            String url = form.mostrar();
            if(url != ""){
                webBrowser1.Navigate(url); 
            }            
        }
               
                        
    }
}
