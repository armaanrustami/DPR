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
            DS.CreateProcess();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListBox();
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
                    temp = DS.processPOP();
                    Firstout.Text = temp.ToString();
                    if (trackBar1.Value >temp){
                        trackBar1.Value--;}
                    if (trackBar1.Value < temp){
                        trackBar1.Value++;}
                    if(trackBar1.Value==temp){
                        DS.removeFromList(temp);
                        DS.processPush(temp);
                    }
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

        public void updateTrackbar(int val)
        {
            
            if (trackBar1.Value > val)
                trackBar1.Value--;
             if (trackBar1.Value < val)
                trackBar1.Value++;
            
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            IsRunning = true;
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            IsRunning = false;
        }
    }
}