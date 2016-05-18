using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{

    interface IWeather

    {
        void notify();

        void register(IObserver obj);

        void remove(IObserver obj);
    }
}