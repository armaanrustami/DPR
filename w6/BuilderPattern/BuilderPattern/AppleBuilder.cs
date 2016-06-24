using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    internal class AppleBuilder : IBuilder
    {
        private string factory_name = "apple";

        private SmartPhone phone;

        public AppleBuilder()
        {
            Name = "iPhone ";
            Color = "black";
            Price = 10;
        }

        public void buildGold(bool toggle)
        {
            HasGold = toggle;
            Price += 15;
        }

        public void buildNFC(bool toggle)
        {
            HasNFC = toggle;
            Price += 5;
        }

        public void buildScreen(bool toggle)
        {
            HasScreen = toggle;
            Price += 2;
        }

        public void buildSpeaker(bool toggle)
        {
            HasSpeaker = toggle;
            Price += 23;
        }

        public void buildWifi(bool toggle)
        {
            HasWifi = toggle;
        }

        public String getName()
        {
            return factory_name;
        }

        public SmartPhone getPhone()
        {
            return new SmartPhone(;
        }
    }
}