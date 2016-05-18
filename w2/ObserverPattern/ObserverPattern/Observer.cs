using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Observer : IObserver
    {
        protected float humidity { get; set; }
        protected float pressure { set; get; }
        protected float temperature { get; set; }
        private String City { get; set; }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Console.WriteLine("Received an update - " + ToString());
        }
    }
}