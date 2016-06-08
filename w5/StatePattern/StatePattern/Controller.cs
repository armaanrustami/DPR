
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
   public class Controller
    {
        private State state;
        public int Speed{get;set;}
        public bool currentstate;
             
        public Controller()
        {
            state = null;
        }

        public void setState(State state) { this.state = state; }
        public State getState() { return state; }
    }
}
