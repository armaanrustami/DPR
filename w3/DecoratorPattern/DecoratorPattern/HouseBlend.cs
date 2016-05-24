namespace DecoratorPattern
{
    internal class HouseBlend : IBeverage
    {
        private string description;

        public HouseBlend()
        {
            description = "House blend coffee";
        }

        public double cost() { return 2.00; }
        public string getDescription() {return description;}

        public override string ToString() { return getDescription() + "     " + cost(); }
    }
}