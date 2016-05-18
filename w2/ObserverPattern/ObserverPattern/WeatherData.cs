using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{





    class WeatherData : IWeather

    {
        private List<IObserver> Observers;
        private List<string> Cities;
        float Temperature { get; set; }
        float Humidity { get; set; }
        float Pressure { set; get; }
        String City {get;set;}



       

        public WeatherData()
        {
            Observers = new List<IObserver>();
            Cities = new List<string>();
            Cities.Add("UK");
            Cities.Add("USA");
            Cities.Add("UAE");
            Cities.Add("NL");
            Cities.Add("PL");
        }

        public void notify(){
            foreach (IObserver item in Observers)
            {
                item.Update(Temperature, Humidity, Pressure);
            }
        }


        public void register(IObserver observer)

        {
            Observers.Add(observer);
        }

      

        public void remove(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void SetMeasurement(float temp, float humidity, float pressure)
        {      

            Temperature = temp;
            Humidity = humidity;
            Pressure = pressure;

        }


    



        public void GenerateRandom()
        { 
            Random rand=new Random();
            float temp = rand.Next(-20, 60);
            float hum = rand.Next(1, 100);
            float press = rand.Next(1,100);
            City = Cities[rand.Next(0, Cities.Count - 1)];
            SetMeasurement(temp, hum, press);






        }


    }
}