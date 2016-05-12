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
        private Scheduler DS;
        private FIFO fifo;
        private SSFT ssft;
        Boolean IsRunning = false;
        public Form1()
        {
           
            InitializeComponent();
            DS = new Scheduler();
            fifo = new FIFO();
            ssft = new SSFT();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = DS.CreateProcess();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int temp;
            if (IsRunning) {


                if (radioButton1.Checked)
                {
                    DS.setAlgorithm(fifo);
                    UpdateListBox();
                    temp= DS.processPOP();
                    



                    
                   

                }
            
            
            
            
            
            
            }
        }


        public void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (int item in DS.GetValuesList())
            {
                listBox1.Items.Add(item);
            }

        }
    }
}