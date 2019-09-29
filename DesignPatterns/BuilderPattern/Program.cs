using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractPerson fatPerson = new FatPerson();
            AbstractPerson thinPerson = new ThinPerson();

            BuilderDirector builder = new BuilderDirector(fatPerson);
            builder.CreatePerson();
            Console.ReadKey();
        }
    }
}
