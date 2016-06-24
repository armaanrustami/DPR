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
        private List<IBuilder> builders;
        private List<SmartPhone> phones;

        public UI()
        {
            InitializeComponent();
            phones = new List<SmartPhone>();
            builders = new List<IBuilder>();
            builders.Add(new AppleBuilder());
            builders.Add(new SamsungBuilder());
        }

        private enum BUILDERS
        {
            APPLE = 0,
            SAMSUNG = 1,
            NONE,
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IBuilder builder = getBuilder(getSelectedBuilder());
            phones.Add(builder.getPhone());
            update(phones, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            phones.Remove((SmartPhone)listBox1.SelectedItem);
            update(phones, listBox1);
            label2.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            IBuilder builder = getBuilder(getSelectedBuilder());
            builder.buildGold(((CheckBox)sender).Checked);
        }

        private IBuilder getBuilder(BUILDERS builder)
        {
            switch (builder)
            {
                case BUILDERS.APPLE:
                    return builders[0];

                case BUILDERS.SAMSUNG:
                    return builders[1];

                case BUILDERS.NONE:
                    return builders[0]; // default

                default:
                    throw new ArgumentException("invalid builder");
            }
        }

        private BUILDERS getSelectedBuilder()
        {
            switch (comboBox1.Text)
            {
                case "Apple":
                    return BUILDERS.APPLE;

                case "Samsung":
                    return BUILDERS.SAMSUNG;

                default:
                    return BUILDERS.NONE;
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            label2.Text = ((SmartPhone)listBox1.SelectedItem).getInfo();
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