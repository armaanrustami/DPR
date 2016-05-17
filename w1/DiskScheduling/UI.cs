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

        /// <summary>
        /// updates the listbox that shows the numbers
        /// </summary>
        public void updateListBox()
        {
            listBox1.Items.Clear();

            foreach (int item in scheduler.getValues())
            {
                listBox1.Items.Add(item);
            }
        }

        /// <summary>
        /// updates the trackbar to go to a new number
        /// </summary>
        /// <param name="val"></param>
        public void updateTrackbar(int val)
        {
            if (trackBar1.Value > val)
            {
                trackBar1.Value--;
                scheduler.setDirection(-1);
            }
            if (trackBar1.Value < val)
            {
                trackBar1.Value++;
                scheduler.setDirection(1);
            }
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
            {
                selected_algorithm = Scheduler.ALGORITHMS.SCAN;
                resort();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                selected_algorithm = Scheduler.ALGORITHMS.CSCAN;
        }

        /// <summary>
        /// called when a resort of the listbox should happen
        /// </summary>
        private void resort()
        {
            updateFirstOut();

            // get latest data needed for specific algorithms
            switch (selected_algorithm)
            {
                case Scheduler.ALGORITHMS.SSTF:
                    scheduler.setStartingData(Convert.ToInt32(Firstout.Text));
                    break;

                case Scheduler.ALGORITHMS.SCAN:
                    scheduler.setStartingData(Convert.ToInt32(Firstout.Text));
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

        /// <summary>
        /// updates the small text over the listbox with the first value in the box
        /// </summary>
        private void updateFirstOut()
        {
            Firstout.Text = Convert.ToString(listBox1.Items[0]);
            listBox1.Items.Remove(0);
        }

        /// <summary>
        /// updates the listbox for the next tick
        /// </summary>
        private void updateForNextValue()
        {
            scheduler.removeValue();
            scheduler.generateValue();
            resort();
        }
    }
}