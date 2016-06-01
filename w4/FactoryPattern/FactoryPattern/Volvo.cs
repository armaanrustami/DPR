using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Volvo : ICar
    {
        private string model;
        private ICar.TYPE type;

        public Volvo(ICar.TYPE type)
        {
            this.type = type;
        }

        public override void honk()
        {
            Console.WriteLine("honk from volvo");
        }

        public override string ToString()
        {
            return "Volvo " + type.ToString();
        }
    }
}