using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Stop:State
    {
        public void doAction(Controller control)
        {
            control.currentstate = false;
        }
        public override string ToString()
        {
            return "Car stopped";
        }
    }
}
