using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Composite : Component
    {
        public override void Add(Component component)
        {
            this.Children.Add(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new string('-', depth)}    {this.Name}");

            // 深度遍历

            foreach (var item in Children)
            {
                item.Display(depth + 1);
            }
        }

        public override void Remove(Component component)
        {
            this.Children.Remove(component);
        }
    }
}
