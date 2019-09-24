using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class SqlLite : Database
    {
        public override void Add()
        {
            Console.WriteLine("Add For SqlLite");
        }

        public override void Remove()
        {
            Console.WriteLine("Remove For SqlLite");
        }
    }
}
