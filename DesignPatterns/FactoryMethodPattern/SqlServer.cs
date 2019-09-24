using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class SqlServer: Database
    {
        public override void Add()
        {
            Console.WriteLine("Add For SqlServer");
        }

        public override void Remove()
        {
            Console.WriteLine("Remove For SqlServer");
        }
    }
}
