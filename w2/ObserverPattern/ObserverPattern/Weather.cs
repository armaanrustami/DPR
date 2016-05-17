using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Weather
    {
        private List<string> cities;
        private string City;
        private List<ISubject> Observers;
        private int temperature;

        public Weather()
        {
            Observers = new List<ISubject>();
            cities = new List<string>();
            cities.Add("UAE");
            cities.Add("NL");
            cities.Add("USA");
            cities.Add("UK");
        }

        public ISubject getState()
        {
            return null;
        }

        public void notifyObservers()
        {
        }

        public void registedObserver(ISubject observer)
        {
            Observers.Add(observer);
        }

        public void removeObserver(ISubject observer)
        {
            Observers.Remove(observer);
        }

        public void setState(ISubject obj)
        {
        }
    }
}