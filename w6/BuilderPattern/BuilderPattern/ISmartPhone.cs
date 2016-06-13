using System;

namespace BuilderPattern
{
    internal interface ISmartPhone
    {
        String IMEI { get; set; }

        String Model();

        decimal Price();
        String Color();
    }
}