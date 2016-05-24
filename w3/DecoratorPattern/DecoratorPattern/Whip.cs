namespace DecoratorPattern
{
    internal class Whip : Decorator
    {
        public Whip(IBeverage bev)
            : base(bev)
        {
            description = " + Whip";
            Cost = .50;
        }

        public override double cost() { return base.cost() + Cost; }

        public override string getDescription() { return base.getDescription() + description; }

        public override string ToString() { return getDescription(); }
    }
}