namespace BuilderPattern
{
    internal abstract class Apple : ISmartPhone
    {
        public abstract string IMEI { get; set; }

        public abstract string Model();

        public abstract decimal Price();
        public abstract string Color();
       
    }
}