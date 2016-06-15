using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class SamsungBuilder
    {
        private Brand brand = new Brand();

        public static string getInfo(ISmartPhone item)
        {
            if (item != null)
                return "Samsung S7Edge " + item.Model() + "Color " + item.Color() + " IMEI NO: " + item.IMEI + " Price " + item.Price();
            return "please select an item";
        }

        public Brand Built()
        {
            brand.add(new SamsungS7Edge("736279e37", "Gray", 642));
            brand.add(new SamsungS7Edge("736276d7", "Gold", 464));
            brand.add(new SamsungS7Edge("736277837", "Silver", 700));
            brand.add(new SamsungS7Edge("523wfse45", "White", 800));
            return brand;
        }

        public void removeItem(ISmartPhone item)
        {
            brand.removeItem(item);
        }
    }
}