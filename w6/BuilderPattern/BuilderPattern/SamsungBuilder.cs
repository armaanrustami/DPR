using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    internal class SamsungBuilder : IBuilder
    {
        private string name = "samsung";
        private SmartPhone phone;

        public SamsungBuilder()
        {
            phone = new SmartPhone();
            phone.Name = "Galaxy ";
            phone.Color = "yellow";
            phone.Price = 15;
        }

        public void buildGold(bool toggle)
        {
            phone.HasGold = toggle;
            phone.Price += 10;
        }

        public void buildNFC(bool toggle)
        {
            phone.HasNFC = toggle;
            phone.Price += 3;
        }

        public void buildScreen(bool toggle)
        {
            phone.HasScreen = toggle;
            phone.Price += 7;
        }

        public void buildSpeaker(bool toggle)
        {
            phone.HasSpeaker = toggle;
            phone.Price += 9;
        }

        public void buildWifi(bool toggle)
        {
            phone.HasWifi = toggle;
            phone.Price += 13;
        }

        public String getName()
        {
            return name;
        }

        public SmartPhone getPhone()
        {
            return phone;
        }
    }
}