using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
   public class Audi : ICarType
    {

        private List<string> car;
  
        public Audi()
        {
            car = new List<string>();
            car.Add("A9");
            car.Add("Q5");
            car.Add("A4");
         

       
            
        }


      
    }
}
