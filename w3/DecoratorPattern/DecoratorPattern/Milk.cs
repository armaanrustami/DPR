namespace DecoratorPattern
{
    internal class Milk : Decorator
    {
        public Milk(IBeverage bev)
            : base(bev)
        {
            description = " + Milk";
            Cost = .90;
        }

        public override double cost(){return base.cost() + Cost;}

        public override string getDescription(){ return base.getDescription() + description;}

        public override string ToString() { return getDescription();}
    }
}