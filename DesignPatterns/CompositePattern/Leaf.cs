using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Leaf : Component
    {
        public override void Add(Component component)
        {
            
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new string('-', depth)}    {this.Name}");
        }

        public override void Remove(Component component)
        {
           
        }
    }
}
