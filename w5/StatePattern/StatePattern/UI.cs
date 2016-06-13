using System;
using System.Drawing;
using System.Windows.Forms;

namespace StatePattern
{
    public partial class UI : Form
    {
        public Controller car;
        public State state;
        private int value = 0;

        public UI()
        {
            InitializeComponent();
            car = new Controller();
            state = null;
        }

        public void resetCheckBoxes()
        {
            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox3.CheckState = CheckState.Unchecked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && radioButton1.Checked) { checkBox2.CheckState = CheckState.Unchecked; value = 1; }
            else if (!checkBox1.Checked) value = 0;
            else { checkBox1.CheckState = CheckState.Unchecked; value = 4; }

            timer1_Tick(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked && radioButton1.Checked) { checkBox1.CheckState = CheckState.Unchecked; value = 2; }
            else if (!checkBox2.Checked) value = 0;
            else { value = 4; resetCheckBoxes(); }
            timer1_Tick(sender, e);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked && radioButton1.Checked)
            {
                checkBox1.CheckState = CheckState.Unchecked;
                checkBox2.CheckState = CheckState.Unchecked; value = 3;
            }
            else if (!checkBox2.Checked) value = 0;
            else { resetCheckBoxes(); value = 4; }
            timer1_Tick(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            value = 0;
            state = new Start();
            car.setState(state);
            state.doAction(car);
            label3.BackColor = Color.Green;
            label3.Text = car.getState().ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            resetCheckBoxes();
            value = 4;

            timer1_Tick(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (value)
            {
                case 1:
                    {
                        try
                        {
                            if (state != null)
                            {
                                checkBox2.CheckState = CheckState.Unchecked;
                                checkBox3.CheckState = CheckState.Unchecked;
                                state = new SpeedUp();
                                car.setState(state);
                                state.doAction(car);
                                if (car.Speed <= 259)
                                {
                                    label3.BackColor = Color.Green;
                                    trackBar1.Value = car.Speed;
                                    label3.Text = car.getState().ToString();
                                }
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
                        try
                        {
                            if (state != null)
                            {
                                checkBox1.CheckState = CheckState.Unchecked;
                                checkBox3.CheckState = CheckState.Unchecked;
                                state = new SpeedDown();
                                car.setState(state);
                                state.doAction(car);
                                if (car.Speed >= 1)
                                {
                                    label3.BackColor = Color.Green;
                                    trackBar1.Value = car.Speed;
                                    label3.Text = car.getState().ToString();
                                }
                            }
                        }
                        catch (Exception g)
                        {
                            resetCheckBoxes();
                            label3.Text = "Car is Stopped try to speedup";
                            label3.BackColor = Color.Red;
                        }
                    }
                    break;

                case 3:
                    {
                        checkBox1.CheckState = CheckState.Unchecked;
                        checkBox2.CheckState = CheckState.Unchecked;
                        state = new Brake();
                        car.setState(state);

                        if (car.Speed > 5)
                        {
                            state.doAction(car);
                            label3.BackColor = Color.Green;
                            label3.Text = car.getState().ToString();
                            trackBar1.Value = car.Speed;
                        }
                    }

                    break;

                case 4:
                    {
                        if (car.Speed == 0)
                        {
                            resetCheckBoxes();
                            state = new OFF();
                            car.setState(state);
                            state.doAction(car);
                            label3.Text = car.getState().ToString();
                            label3.BackColor = Color.Red;
                            value = 0;
                        }
                        else
                        {
                            state = new Brake();
                            car.setState(state);

                            state.doAction(car);
                            label3.BackColor = Color.Green;
                            label3.Text = car.getState().ToString();
                            trackBar1.Value = car.Speed;
                            value = 4;
                        }
                    }
                    break;
            }
        }
    }
}