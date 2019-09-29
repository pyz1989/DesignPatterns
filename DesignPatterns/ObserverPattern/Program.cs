using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new ConcreteSubject()
            {
                 SubjectState = "Hello"
            };
            IObserver observer1 = new ConcreteObserver1(subject, "张三");
            IObserver observer2 = new ConcreteObserver1(subject, "李四");

            subject.Add(observer1);
            subject.Add(observer2);

            subject.SubjectState = "天塌了";
            subject.Notify();
           Console.ReadKey();
        }
    }
}
