using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _057_FileSystemWatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {

            Thread.Sleep(10000);

            String destino = String.Format(@"C:\Users\Admin\Desktop\BKP\{0}", e.Name);

            try
            {
                File.Copy(e.FullPath, destino);
            }
            catch { }
        }
    }
}
