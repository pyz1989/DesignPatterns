using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractMediator mediator = new ConcreteMediator();
            AbstractColleague colleague1 = new Colleage("张三", mediator);
            AbstractColleague colleague2 = new Colleage("李四", mediator);

            mediator.Add(colleague1);
            mediator.Add(colleague2);
            colleague1.Send("李四", "在吗？");
            colleague2.Send("张三", "我在这儿！");
            Console.ReadKey();
        }
    }
}
