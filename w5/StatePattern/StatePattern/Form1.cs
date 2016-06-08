using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePattern
{
    public partial class Form1 : Form
    {

        public Controller car;
        public State state;
        public Start start;
        public Stop stop;
        int value=0;
        public Form1()

        {
            InitializeComponent();
            car = new Controller();

            state = null;
            stop = null; 
            start = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            state = new Start();
            start = (Start)state;
            car.setState(state);
            state.doAction(car);
            label3.BackColor = Color.Green;
            label3.Text = car.getState().ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
            state = new Stop();
            stop = (Stop)state;
            start = null;
            car.setState(state);
            state.doAction(car);
            label3.BackColor = Color.Green;
            label3.Text = car.getState().ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            switch (value)
            {


                case 1:
                    {
                        try
                        {

                            checkBox2.CheckState = CheckState.Unchecked;
                            if (start != null)
                            {
                                state = new SpeedUp();
                                car.setState(state);
                                state.doAction(car);
                                label3.BackColor = Color.Green;
                                trackBar1.Value = car.Speed;
                                label3.Text = car.getState().ToString();
                            }
                        }
                        catch (Exception g)
                        {
                            label3.Text = "Car damaged";
                            label3.BackColor = Color.Red;
                        }
                    }
                    break;

                case 2:
                    {
                        checkBox1.CheckState = CheckState.Unchecked;
                        try
                        {
                            if (start != null|| stop!=null)
                            {
                                state = new SpeedDown();
                                car.setState(state);
                                state.doAction(car);
                                label3.BackColor = Color.Green;
                                trackBar1.Value = car.Speed;
                                label3.Text = car.getState().ToString();
                            }
                        }
                        catch (Exception g)
                        {
                            label3.Text = "Car damaged";
                            label3.BackColor = Color.Red;
                        }
                    }
                    break;
            }
       
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            value = 1;
            timer1_Tick(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            value = 2;
            timer1_Tick(sender, e);
        }

       
    }
}
