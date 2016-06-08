using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
 public class Start:State
    {

        public void doAction(Controller control)
        {
            control.currentstate = true;
        }
        public override string ToString()
        {
            return " Car is Started UP";
        }
    }
}
