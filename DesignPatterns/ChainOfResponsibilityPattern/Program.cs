using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler handler1 = new ConcreteHandler1();
            AbstractHandler handler2 = new ConcreteHandler2();
            AbstractHandler handler3 = new ConcreteHandler3();
            handler1.SetHandler(handler2);
            handler2.SetHandler(handler3);
            handler1.Request(3);
            Console.ReadKey();
        }
    }
}
