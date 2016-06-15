using System;

namespace BuilderPattern
{
    internal class IPhone6sPlus : Apple
    {
        private String Imei, color;
        private decimal price;

        public IPhone6sPlus(String imei, String color, decimal price)
        {
            Imei = imei;
            this.color = color;
            this.price = price;
        }

        public override string IMEI
        {
            get
            {
                return Imei;
            }
            set
            {
                value = Imei;
            }
        }

        public override string Color()
        {
            return color;
        }

        public override string Model()
        {
            return "iPhone 6s  Plus";
        }

        public override decimal Price()
        {
            return price;
        }

        public override string ToString()
        {
            return "IPhone 6S+ Price " + Price();
        }
    }
}