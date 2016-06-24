using System;

namespace BuilderPattern
{
    internal class SmartPhone
    {
        private bool hasGold, hasNFC, hasScreen, hasSpeaker, hasWifi;

        private String name, color;

        private decimal price;

        public SmartPhone()
        {
            name = "new";
            color = "green";
            price = 0;
        }

        public String Color
        {
            get { return color; }
            set { color = value; }
        }

        public bool HasGold
        {
            get { return hasGold; }
            set { hasGold = value; }
        }

        public bool HasNFC
        {
            get { return hasNFC; }
            set { hasNFC = value; }
        }

        public bool HasScreen
        {
            get { return hasScreen; }
            set { hasScreen = value; }
        }

        public bool HasSpeaker
        {
            get { return hasSpeaker; }
            set { hasSpeaker = value; }
        }

        public bool HasWifi
        {
            get { return hasWifi; }
            set { hasWifi = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string getInfo()
        {
            return name + ": costs " + price + "\n" +
                    "hasGold: " + hasGold + "\n" +
                    "hasNFC: " + hasNFC + "\n" +
                    "hasScreen: " + hasScreen + "\n" +
                    "hasSpeaker: " + hasSpeaker + "\n" +
                    "hasWifi: " + hasWifi + "\n";
        }

        public override string ToString()
        {
            return name;
        }
    }
}