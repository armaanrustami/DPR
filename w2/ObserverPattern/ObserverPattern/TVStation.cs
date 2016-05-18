using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class TVStation : Observer
    {
        public override string ToString()
        {
            return "TVStation - " + humidity;
        }
    }
}