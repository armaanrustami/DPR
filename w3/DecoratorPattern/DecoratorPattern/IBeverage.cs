using System;

namespace DecoratorPattern
{
    internal interface IBeverage
    {
        double cost();

        String getDescription();
    }
}