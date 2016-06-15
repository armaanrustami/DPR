using System;

namespace BuilderPattern
{
    internal interface ISmartPhone
    {
        String IMEI { get; set; }

        String Color();

        String Model();

        decimal Price();
    }
}