using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class ICar
    {
        public enum TYPE
        {
            COMPACT = 0,
            LIMOUSINE,
            SUV,
            HYBRID,
        };

        public abstract void honk();

        public override string ToString()
        {
            return "ICar";
        }
    }
}