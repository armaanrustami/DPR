using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Observer: IObserver
    {

        float Temperature { get; set; }
        float Humidity { get; set; }
        float Pressure { set; get; }
       
             
        public void Update(float temp,float humidity,float pressure)
        {
            Temperature = temp;
            Humidity = humidity;
            Pressure = pressure;
           
        
        }
    }
}
