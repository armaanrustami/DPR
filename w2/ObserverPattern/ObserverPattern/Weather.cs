using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Weather
    {
        private List<ISubject> Observers;
        List<string> cities;
        int temperature;
        string City;
        public Weather()
        {
            Observers = new List<ISubject>();
            cities = new List<string>();
            cities.Add("UAE");
            cities.Add("NL");
            cities.Add("USA");
            cities.Add("UK");
           
        }
        
     public void  registedObserver(ISubject observer){

         Observers.Add(observer);
     }

     public void removeObserver(ISubject observer) {
         Observers.Remove(observer);
     }

      public void  notifyObservers(){

      }
       
        public ISubject getState(){
        return null;
        }
        public void setState(ISubject obj){
        }



    }
}
