using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal interface ISubject
    {
        void notify();

        void register(IObserver obj);

        void remove(IObserver obj);
    }
}