using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class MySql : Database
    {
        public override void Add()
        {
            Console.WriteLine("Add For MySql");
        }

        public override void Remove()
        {
            Console.WriteLine("Remove For MySql");
        }
    }
}
