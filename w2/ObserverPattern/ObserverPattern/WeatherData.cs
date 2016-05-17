﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern

{
    class WeatherData :ISubject
    {

        private List<IObserver> Observers;

        float temperature,humidity,pressure;
        public WeatherData()
        {
            Observers = new List<IObserver>();
        }

        
        public void register(IObserver observer)
        {

            Observers.Add(observer);
        }

        public void remove(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void notify()
        {
            foreach (IObserver item in Observers)
            {
                item.Update(temperature, humidity, pressure);
            }

        }
        public void SetMeasurement(float temp, float humidity, float pressure) { }

    }
}
