using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
   public class Tesla : ICarType
    {
       

           private List<string> car;
           public List<string> ops;
           public Tesla()
           {
               car = new List<string>();
               car.Add("S");
               car.Add("X");
               car.Add("3");
              

           }



       
       }
    
}
