using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    /// <summary>
    /// 组成
    /// </summary>
    public abstract class Component
    {

        public List<Component> Children { get; set; } = new List<Component>();

        public string Name { get; set; }

        public abstract void Add(Component component);

        public abstract void Remove(Component component);

        public abstract void Display(int depth);

    }
}
