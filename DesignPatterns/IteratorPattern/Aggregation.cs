using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// HashSet + List 这样的一个聚合对象
    /// </summary>
    public class Aggregation
    {
        public int Length { get; set; }

        public List<int> list = new List<int>();

        public IMyEnumerable GetEnumerable()
        {
            return new MyEnumerable(this);
        }

        public void Add(int item)
        {
            list.Add(item);
        }
    }
}
