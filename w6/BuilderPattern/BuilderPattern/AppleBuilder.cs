using System.Collections.Generic;

namespace BuilderPattern
{
    internal class AppleBuilder
    {
        private Brand brand = new Brand();

        public Brand Built()
        {
            brand.add(new IPhone6sPlus("736279e37", "Gray", 658));
            brand.add(new IPhone6sPlus("736276d7", "Gold", 359));
            brand.add(new IPhone6s("736277837", "Silver", 756));
            brand.add(new IPhone6s("523wfse45", "White", 456));
            return brand;
        }

        public string getInfo(ISmartPhone item)
        {
            if (item != null)
                return "Iphone  " + item.Model() + "Color " + item.Color() + " IMEI NO: " + item.IMEI + " Price " + item.Price();
            return "Please selct An item";
        }

        public List<ISmartPhone> getItems()
        {
            return brand.getPhones();
        }

        public void removeItem(ISmartPhone item)
        {
            brand.removeItem(item);
        }
    }
}