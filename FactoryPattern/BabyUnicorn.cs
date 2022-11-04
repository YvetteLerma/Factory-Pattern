using System;
namespace FactoryPattern
{
    public class BabyUnicorn : IVehicle
    {
        public BabyUnicorn()
        {
        }

        public void Drive()
        {
            Console.WriteLine("The baby unicorn has 3 legs. YAAAY!");
        }
    }
}

