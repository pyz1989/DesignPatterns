using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Component component = new Composite();

            Component technology = new Composite() { Name = "net技术" };
            Component program= new Composite() { Name = "编程语言" };
            // 一级
            component.Add(technology);
            component.Add(program);
            // 二级
            technology.Add(new Leaf() { Name = "net新手" });
            technology.Add(new Leaf() { Name = "C#" });
            program.Add(new Leaf() { Name = "Java" });


            component.Display(2);
            Console.ReadKey();
        }
    }
}
