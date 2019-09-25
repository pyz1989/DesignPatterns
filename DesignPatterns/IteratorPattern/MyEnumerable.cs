using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class MyEnumerable : IMyEnumerable
    {
        private Aggregation aggregation = new Aggregation();

        private int index = 0;

        private int current = 0;

        public MyEnumerable(Aggregation aggregation)
        {
            this.aggregation = aggregation;
        }
        public int Current
        {
            get => current;
        }

        public bool MoveNext()
        {
            if (index < aggregation.list.Count)
            {
                this.current = aggregation.list[index];
                index++;
                return true;
            }
            index = 0;
            return false;
        }
    }
}
