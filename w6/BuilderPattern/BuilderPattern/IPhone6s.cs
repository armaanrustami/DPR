using System;

namespace BuilderPattern
{
    internal class IPhone6s : Apple
    {
        private String Imei, color;
        private decimal price;

        public IPhone6s(String imei, string color, decimal price)
        {
            this.color = color;
            this.Imei = imei;
            this.price = price;
        }

        public override string IMEI
        {
            get { return Imei; }
            set { value = Imei; }
        }

        public override string Color()
        {
            return color;
        }

        public override string Model()
        {
            return "iPhone 6s";
        }

        public override decimal Price()
        {
            return price;
        }

        public override string ToString()
        {
            return "IPhone 6S Price " + Price();
        }
    }
}