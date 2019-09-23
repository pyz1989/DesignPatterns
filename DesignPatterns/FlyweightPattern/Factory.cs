using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    public class Factory
    {
        static Dictionary<int, FlyWeight> cache = new Dictionary<int, FlyWeight>();

        public static FlyWeight CreateInstance(int num)
        {
            if (cache.ContainsKey(num))
            {
                return cache[num];
            }
            cache.Add(num, new ConcreteFlyWeight());
            return cache[num];
        }
    }
}
