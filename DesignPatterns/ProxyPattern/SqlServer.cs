using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class SqlServer : AbstractDatabase
    {
        public override void Add()
        {
            Console.WriteLine($"SqlServer Add");
        }

        public override void Remove()
        {
            Console.WriteLine($"SqlServer Remove");
        }
    }
}
