﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Push: IObserver
    {

      public  int Temperature{get;set;}

        public void Update(float temp,float humidity,float pressure)
        {
            
        }
    }
}
