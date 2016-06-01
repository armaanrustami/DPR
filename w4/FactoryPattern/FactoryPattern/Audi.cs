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
        private List<string> ops;
        public Audi()
        {
            car = new List<string>();
            car.Add("Compact");
            car.Add("Hybrid");
            car.Add("Limosine");
            car.Add("SUV");
            car.Add("Estate");

            ops = new List<string>();
            ops.Add("Drive");
            ops.Add("Wash");
            ops.Add("Maintenance");

            
        }



        public string CarSpec()
        {
          Random random = new Random();
          int  c = random.Next() % 4;
          int  o  = random.Next() % 3;

          string cr = car.ElementAt<string>(c);
          string op  = ops.ElementAt<string>(o);

          return cr + " , " + op;
         
        }
    }
}
