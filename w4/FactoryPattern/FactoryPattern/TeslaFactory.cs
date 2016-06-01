using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class TeslaFactory : ICarFactory
    {
        public ICarType CreateCar()
        {
            return new Tesla();
        }
    }
}
