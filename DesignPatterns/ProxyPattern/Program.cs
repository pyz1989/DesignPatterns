using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Add();
            proxy.Remove();
            Console.ReadKey();
        }
    }
}
