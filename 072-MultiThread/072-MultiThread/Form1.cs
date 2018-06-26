using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _072_MultiThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Thread.CurrentThread.ManagedThreadId.ToString(), "AAAA");
            MessageBox.Show(Thread.CurrentThread.ManagedThreadId.ToString(), "BBBB");
            MessageBox.Show(Thread.CurrentThread.ManagedThreadId.ToString(), "CCCC");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(MostrarMensagem)).Start();
            new Thread(new ThreadStart(MostrarMensagem)).Start();
            new Thread(new ThreadStart(MostrarMensagem)).Start();

        }

        void MostrarMensagem()
        {
            MessageBox.Show(Thread.CurrentThread.ManagedThreadId.ToString(), "Com Thread");            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Thread(new ParameterizedThreadStart(MostrarMensagemComParemetro)).Start("AA");
            new Thread(new ParameterizedThreadStart(MostrarMensagemComParemetro)).Start("BB");
            new Thread(new ParameterizedThreadStart(MostrarMensagemComParemetro)).Start("CC");
        }

        private void MostrarMensagemComParemetro(object obj)
        {
            MessageBox.Show(Thread.CurrentThread.ManagedThreadId.ToString(), obj.ToString());         
        }

       
    }
}
