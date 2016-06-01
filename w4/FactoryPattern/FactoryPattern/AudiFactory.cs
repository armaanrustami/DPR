using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class AudiFactory : ICarFactory
    {
        public ICar CreateCar(ICar.TYPE type)
        {
            return new Audi(type);
        }

        public override string ToString()
        {
            return "AudiFactory";
        }
    }
}