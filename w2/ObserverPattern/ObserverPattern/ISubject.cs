using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    interface ISubject
    {


        void register(IObserver obj);
        void remove(IObserver obj);
        void notify();
    }
}
