using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskScheduling
{
    public partial class Form1 : Form
    {
        Disk_Scheduling DS;
        public Form1()
        {
            DS = new Disk_Scheduling();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listBox1.DataSource = DS.CreateProcess();
        }
    }
}
