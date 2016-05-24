using System;

namespace DecoratorPattern
{
    internal abstract class Decorator : IBeverage
    {
        protected IBeverage beverage;
        protected double Cost;
        protected String description;

        public Decorator(IBeverage bev)
        {
            beverage = bev;
        }

        public virtual double cost(){ return beverage.cost();}

        public virtual string getDescription(){return beverage.getDescription(); }
    }
}