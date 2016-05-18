using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class UI : Form
    {
        private List<IObserver> observers = null;
        private List<ISubject> subjects = null;

        public UI()
        {
            InitializeComponent();
            subjects = new List<ISubject>();
            observers = new List<IObserver>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IObserver o = parseOberverChoice();
            observers.Add(o);
            updateListBox(listBox1, observers);
            Console.WriteLine("Add observer.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IObserver o = (IObserver)listBox1.SelectedItem;
            observers.Remove(o);
            unsubscribeObserver();
            updateListBox(listBox1, observers);
            Console.WriteLine("Remove observer.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null && listBox1.SelectedItem != null)
            {
                IObserver o = (IObserver)listBox1.SelectedItem;
                ISubject s = (ISubject)listBox2.SelectedItem;
                s.register(o);
                Console.WriteLine("Subscribe an observer.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                WeatherData s = (WeatherData)listBox2.SelectedItem;
                s.GenerateRandom();
                s.notify();
                updateListBox(listBox1, observers);
                updateListBox(listBox2, subjects);
            }
            Console.WriteLine("Update subject.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                ISubject s = (ISubject)listBox2.SelectedItem;
                subjects.Remove(s);
                unsubscribeObservers();
                updateListBox(listBox2, subjects);
            }
            Console.WriteLine("Remove subject.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            subjects.Add(new WeatherData());
            updateListBox(listBox2, subjects);
            Console.WriteLine("Add subject.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null && listBox2.SelectedItem != null)
            {
                IObserver o = (IObserver)listBox1.SelectedItem;
                ISubject s = (ISubject)listBox2.SelectedItem;
                s.remove(o);
            }
            Console.WriteLine("Unsubscribe an observer.");
        }

        private IObserver parseOberverChoice()
        {
            if (comboBox1.Text != "" && comboBox1.Text != null)
            {
                if (comboBox1.Text == "Radio") return new RadioStation();
                if (comboBox1.Text == "Television") return new TVStation();
                if (comboBox1.Text == "Website") return new Website();
                throw new ArgumentException("Invalid choice!");
            }
            Console.WriteLine("Creating a default observer.");
            return new RadioStation();
        }

        private void unsubscribeObserver()
        {
            if (listBox1.SelectedItem != null)
            {
                IObserver o = (IObserver)listBox2.SelectedItem;
                foreach (ISubject s in subjects)
                {
                    s.remove(o);
                }
            }
            Console.WriteLine("Unsubscribe an observer.");
        }

        private void unsubscribeObservers()
        {
            if (listBox2.SelectedItem != null)
            {
                ISubject s = (ISubject)listBox2.SelectedItem;
                foreach (IObserver o in observers)
                {
                    s.remove(o);
                }
            }
            Console.WriteLine("Unsubscribe all observers attached to subject.");
        }

        private void updateListBox<T>(ListBox l, List<T> data)
        {
            l.Items.Clear();
            foreach (T val in data)
            {
                l.Items.Add(val);
            }
            Console.WriteLine("Update on " + l.Name);
        }
    }
}