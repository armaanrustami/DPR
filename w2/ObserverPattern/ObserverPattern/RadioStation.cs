using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class RadioStation : Observer
    {
        public override string ToString()
        {
            return "RadioStation - " + temperature;
        }
    }
}