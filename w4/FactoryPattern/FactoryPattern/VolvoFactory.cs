using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VolvoFactory : ICarFactory
    {
        public ICar CreateCar(ICar.TYPE type)
        {
            return new Volvo(type);
        }

        public override string ToString()
        {
            return "VolvoFactory";
        }
    }
}