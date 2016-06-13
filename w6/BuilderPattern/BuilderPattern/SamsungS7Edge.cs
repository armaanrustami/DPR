using System;

namespace BuilderPattern
{
    internal class SamsungS7Edge : Samsung
    {
        private string imei ,color;
        decimal price;
        
        public SamsungS7Edge(String imei,string color,decimal price)
        {
            this.imei = imei;
            this.color = color;
            this.price = price;
        }


        public override string Model()
        {
            return "G9288F";
        }

    

        public override string Color()
        {
            return color;
        }
        public override string ToString()
        {
            return "Samsung S7 Edge Price " + Price() ;
        }

        public override decimal Price()
        {
            return price;
        }

        public override string IMEI
        {
            get
            {
                return imei;
            }
            set
            {
                value = imei;
            }
        }
    }
}