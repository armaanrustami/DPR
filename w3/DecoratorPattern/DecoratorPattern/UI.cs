using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorPattern
{

    
    public partial class UI : Form
    {
        IBeverage beverage;
        public UI()
        {
            InitializeComponent();
            beverage = new Espresso();
            listBox1.Items.Add(beverage);
            beverage = new HouseBlend();
            listBox1.Items.Add(beverage);
             
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            update();
        }

        public void update()
        {
            beverage = null;
           
            if (listBox1.SelectedItem != null)
            {
                beverage = (IBeverage)listBox1.SelectedItem;


                if (milk.Checked && !whip.Checked) beverage = new Milk(beverage);
                if (whip.Checked && !milk.Checked) beverage = new Whip(beverage);
                else if(milk.Checked && whip.Checked)
                {
                    beverage = null;
                    beverage = (IBeverage)listBox1.SelectedItem;
                    beverage = new Milk(beverage);
                    beverage = new Whip(beverage);
                }
                description.Text = beverage.getDescription();
                totalPrice.Text = beverage.cost().ToString();
            }
        }

        private void milk_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        private void whip_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
