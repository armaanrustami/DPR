using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Audi : ICar
    {
        private ICar.TYPE type;

        public Audi(ICar.TYPE type)
        {
            this.type = type;
        }

        public override void honk()
        {
            Console.WriteLine("honk from audi");
        }

        public override string ToString()
        {
            return "Audi " + type.ToString();
        }
    }
}