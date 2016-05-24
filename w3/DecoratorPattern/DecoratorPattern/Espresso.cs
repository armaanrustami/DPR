namespace DecoratorPattern
{
    internal class Espresso : IBeverage
    {
        private string description;

        public Espresso()
        {
            description = "Espresso";
        }

        public double cost(){ return 1.22; }

        public string getDescription(){ return description;}

        public override string ToString() {return getDescription() + "                  " + cost();}
    }
}