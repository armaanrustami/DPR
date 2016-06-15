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
    public partial class UI : Form
    {
        private Brand brand;
        private BRANDS current_brand;

        public UI()
        {
            InitializeComponent();
        }

        private enum BRANDS
        {
            APPLE,
            SAMSUNG,
            NONE,
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Apple":
                    current_brand = BRANDS.APPLE;
                    brand = new AppleBuilder().Built();
                    break;

                case "Samsung":
                    current_brand = BRANDS.SAMSUNG;
                    brand = new SamsungBuilder().Built();
                    break;

                default:
                    current_brand = BRANDS.NONE;
                    return;
            }
            update(brand.getPhones(), listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (brand == null) return;

            switch (current_brand)
            {
                case BRANDS.APPLE:
                    brand.removeItem((ISmartPhone)listBox1.SelectedItem);
                    break;

                case BRANDS.SAMSUNG:
                    brand.removeItem((ISmartPhone)listBox1.SelectedItem);
                    break;

                default:
                    return;
            }
            update(brand.getPhones(), listBox1);
            label2.Text = "";
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            switch (current_brand)
            {
                case BRANDS.APPLE:
                    label2.Text = AppleBuilder.getInfo((ISmartPhone)listBox1.SelectedItem);
                    break;

                case BRANDS.SAMSUNG:
                    label2.Text = SamsungBuilder.getInfo((ISmartPhone)listBox1.SelectedItem);
                    break;

                default:
                    return;
            }
        }

        /// <summary>
        /// Updates the data of a list.
        /// </summary>
        /// <typeparam name="T">Type of data</typeparam>
        /// <param name="data">List containing elements of type T</param>
        /// <param name="box">The listbox to update</param>
        private void update<T>(List<T> data, ListBox box)
        {
            box.Items.Clear();
            foreach (T val in data)
            {
                listBox1.Items.Add(val);
            }
        }
    }
}