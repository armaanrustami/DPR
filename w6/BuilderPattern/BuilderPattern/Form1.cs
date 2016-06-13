using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuilderPattern
{
    public partial class Form1 : Form
    {

        AppleBuilder applebuild;
        SamsungBuilder sambuild;
        Brand brand;
        bool currentB;
        public Form1()
        {
            InitializeComponent();
            applebuild = new AppleBuilder();
            sambuild = new SamsungBuilder();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.Text == "Apple")
            {
                currentB = false;
                brand = applebuild.Built();
                listBox1.Items.Clear();
                foreach (ISmartPhone item in brand.getPhones())
                {
                    listBox1.Items.Add(item);
                }}
                else{
                    
                 brand = sambuild.Built();
                    foreach (Samsung item in brand.getPhones())
                    {
                        listBox1.Items.Add(item);
                    }
                    currentB = true;
                }
                
            
          

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (currentB) { label2.Text= sambuild.getInfo((ISmartPhone)listBox1.SelectedItem); }
            else label2.Text = applebuild.getInfo((ISmartPhone)listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
          
            if (currentB) {sambuild.removeItem ((ISmartPhone)listBox1.SelectedItem); }
            else  applebuild.removeItem((ISmartPhone)listBox1.SelectedItem);
            update();

        }


        public void update() {


            listBox1.Items.Clear();
          
               
                foreach (ISmartPhone item in brand.getPhones())
                {
                    listBox1.Items.Add(item);
                }
            }
  
    }
}
