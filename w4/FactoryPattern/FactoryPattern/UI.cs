using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryPattern
{
    public partial class UI : Form
    {
        private List<Dealer> dealers = null;
        private Random rng = new Random();

        public UI()
        {
            InitializeComponent();

            dealers = new List<Dealer>();
        }

        /// <summary>
        /// Sets the text for a dealer.
        /// </summary>
        public void updateTextBox()
        {
            if (listBox1.SelectedItem == null) return;

            Dealer d = (Dealer)(listBox1.SelectedItem);
            richTextBox1.Text = d.Log();
        }

        /// <summary>
        /// Create a dealer with a random name.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == null || comboBox1.Text == "") return;

            string name = comboBox1.Text;

            if (!dealers.Any(d => d.getName() == name))
            {
                dealers.Add(new Dealer(name));
                clearList(listBox1, dealers);
            }
        }

        /// <summary>
        /// Removes a dealer from the list of dealers
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            dealers.Remove((Dealer)listBox1.SelectedItem);
            clearList(listBox1, dealers);
            richTextBox1.Text = "";
        }

        /// <summary>
        /// Add a factory to a selected dealer.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            Dealer dealer = dealers.Find(d => d.Equals((Dealer)listBox1.SelectedItem));
            dealer.addFactory(getFactoryType(comboBox2));
            clearList(listBox2, dealer.getFactories());
            updateTextBox();
        }

        /// <summary>
        /// Removes a factory form a dealer.
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || listBox2.SelectedItem == null) return;

            Dealer d = (Dealer)listBox1.SelectedItem;
            d.removeFactory((ICarFactory)listBox2.SelectedItem);
            clearList(listBox2, d.getFactories());
            updateTextBox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null ||
                listBox2.SelectedItem == null ||
                comboBox3.Text == null ||
                comboBox3.Text == "") return;

            Dealer d = (Dealer)listBox1.SelectedItem;
            ICarFactory f = (ICarFactory)listBox2.SelectedItem;
            ICar c = f.CreateCar(getCarType(comboBox3));
            d.addCar(f, c);
            clearList(listBox3, d.getCars(f));
            updateTextBox();
        }

        /// <summary>
        /// Removes a car from a dealer
        /// </summary>
        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null ||
                listBox2.SelectedItem == null ||
                listBox3.SelectedItem == null) return;

            Dealer d = (Dealer)listBox1.SelectedItem;
            ICarFactory f = (ICarFactory)listBox2.SelectedItem;
            d.removeCar(f, (ICar)listBox3.SelectedItem);
            clearList(listBox3, d.getCars(f));
            updateTextBox();
        }

        /// <summary>
        /// honk honk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null) return;

            ICar c = (ICar)listBox2.SelectedItem;
            c.honk();
        }

        /// <summary>
        /// Clears a list and adds some data to it.
        /// </summary>
        /// <typeparam name="T">Type of list</typeparam>
        /// <param name="list">List to clear</param>
        /// <param name="data">Data to append to list</param>
        private void clearList<T>(ListBox list, List<T> data)
        {
            list.Items.Clear();

            foreach (T val in data)
            {
                list.Items.Add(val);
            }
        }

        /// <summary>
        /// Extracts type of car from combobox
        /// </summary>
        /// <param name="cb"></param>
        /// <returns></returns>
        private ICar.TYPE getCarType(ComboBox cb)
        {
            // default to avoid complications
            ICar.TYPE t = ICar.TYPE.COMPACT;
            if (cb.Text == null || cb.Text == "") return t;

            if (cb.Text == "LIMOUSINE") t = ICar.TYPE.LIMOUSINE;
            else if (cb.Text == "SUV") t = ICar.TYPE.SUV;
            else if (cb.Text == "HYBRID") t = ICar.TYPE.HYBRID;
            else if (cb.Text == "COMPACT") t = ICar.TYPE.COMPACT;
            else { throw new ArgumentException("Invalid car type"); }

            return t;
        }

        /// <summary>
        /// Extracts type of factory from combobox
        /// </summary>
        /// <param name="cb">combobox with factory data</param>
        /// <returns>factory type</returns>
        private ICarFactory getFactoryType(ComboBox cb)
        {
            // default to avoid complications
            ICarFactory f = new VolvoFactory();

            if (cb.Text == null || cb.Text == "") return f;

            if (cb.Text == "Volvo") f = new VolvoFactory();
            else if (cb.Text == "Audi") f = new AudiFactory();
            else if (cb.Text == "Tesla") f = new TeslaFactory();
            else { throw new ArgumentException("Invalid factory type"); }

            return f;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTextBox();
        }
    }
}