using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
   public class Volvo : ICarType
    {
      

           private List<string> car;
           private List<string> ops;
           public Volvo()
           {
               car = new List<string>();
               car.Add("S60");
               car.Add("V40");
               car.Add("V60 T3");
             



           }



         
       }
    
}
