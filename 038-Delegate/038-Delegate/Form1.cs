using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _038_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //event handler
        {
            MessageBox.Show("oi");
            this.button1.Click -= new System.EventHandler(this.button1_Click);
            //this.button1.Enabled = false;
            
        }
    }
}
