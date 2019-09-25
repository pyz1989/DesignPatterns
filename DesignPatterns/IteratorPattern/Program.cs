using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Aggregation aggregation = new Aggregation();
            aggregation.Add(1);
            aggregation.Add(3);
            aggregation.Add(5);
            IMyEnumerable myEnumerable = aggregation.GetEnumerable();
            while (myEnumerable.MoveNext())
            {
                Console.Write($"{myEnumerable.Current}  ");
            }
            Console.WriteLine();
            while (myEnumerable.MoveNext())
            {
                Console.Write($"{myEnumerable.Current}  ");
            }
            Console.WriteLine();

            Demo();
            Console.ReadKey();
        }

        public static void Demo()
        {
            List<int> intList = new List<int>() { 0, 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("-----------foreach------------");
            foreach (var item in intList)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
            Console.WriteLine("----------- for --------------");
            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{intList[i]}  ");
                
            }
            Console.WriteLine();
            Console.WriteLine("---GetEnumerator + MoveNext---");
            var enumerator = intList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Write($"{enumerator.Current}  ");
            }
            Console.WriteLine();
        }
    }
}
