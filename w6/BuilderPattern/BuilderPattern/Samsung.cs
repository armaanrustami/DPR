using System;

namespace BuilderPattern
{
    internal abstract class Samsung : ISmartPhone
    {
      
        public abstract string Model();
        public abstract decimal Price();
        public abstract string Color();

        public abstract string IMEI{get;set;}
   
    }
}