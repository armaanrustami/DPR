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
    public partial class UI : Form
    {
        private Boolean IsRunning = false;
        private Scheduler scheduler;
        private Scheduler.ALGORITHMS selected_algorithm;

        public UI()
        {
            InitializeComponent();
            scheduler = new Scheduler();
            scheduler.generateValues();
        }

        public void updateListBox()
        {
            listBox1.Items.Clear();

            foreach (int item in scheduler.getValues())
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

        private void Form1_Load(object sender, EventArgs e)
        {
            updateListBox();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                selected_algorithm = Scheduler.ALGORITHMS.FIFO;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                selected_algorithm = Scheduler.ALGORITHMS.SSTF;
                resort();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                selected_algorithm = Scheduler.ALGORITHMS.LOOK;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                selected_algorithm = Scheduler.ALGORITHMS.CLOOK;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                selected_algorithm = Scheduler.ALGORITHMS.SCAN;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                selected_algorithm = Scheduler.ALGORITHMS.CSCAN;
        }

        private void resort()
        {
            switch (selected_algorithm)
            {
                case Scheduler.ALGORITHMS.SSTF:
                    scheduler.setStartingData(Convert.ToInt32(listBox1.Items[0]));
                    break;
            }

            scheduler.sortByAlgorithm(selected_algorithm);
            updateListBox();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            IsRunning = true;
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            IsRunning = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsRunning)
            {
                int val = Convert.ToInt32(listBox1.Items[0]);

                if (trackBar1.Value != val)
                {
                    updateTrackbar(val);
                }
                else
                {
                    updateForNextValue();
                }
            }
        }

        private void updateForNextValue()
        {
            scheduler.removeValue();
            scheduler.generateValue();
            resort();
        }
    }
}