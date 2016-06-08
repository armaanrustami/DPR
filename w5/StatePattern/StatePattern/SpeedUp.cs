using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class SpeedUp:State
    {
        int speed;
        public void doAction(Controller control)
        {
            speed = ++control.Speed;
        }


        public override string ToString()
        {
            return "Speed upped to " + speed;
        }



     
        
    }
}
