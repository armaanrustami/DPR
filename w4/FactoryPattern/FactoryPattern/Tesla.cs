using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Tesla : ICar
    {
        private ICar.TYPE type;

        public Tesla(ICar.TYPE type)
        {
            this.type = type;
        }

        public override void honk()
        {
            Console.WriteLine("honk from tesla");
        }

        public override string ToString()
        {
            return "Tesla " + type.ToString();
        }
    }
}