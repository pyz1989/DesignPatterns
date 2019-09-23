using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    /// <summary>
    /// 享元模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            FlyWeight flyWeight = Factory.CreateInstance(1);
            Console.ReadKey();

        }


        public static void HashCode()
        {
            Dictionary<int, Person> dic = new Dictionary<int, Person>();
            for (int i = 0; i < 10; i++)
            {
                Person person = new Person();
                if (dic.ContainsKey(person.GetHashCode()))
                {
                    person = dic[person.GetHashCode()];
                }
                dic.Add(person.GetHashCode(), person);
            }
        }
    }

    internal class Person
    {
    }
}
