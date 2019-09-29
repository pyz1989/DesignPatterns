using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class ConcreteObserver1 : IObserver
    {
        ISubject subject = null;

        string name = string.Empty;

        public ConcreteObserver1(ISubject subject, string name)
        {
            this.name = name;
            this.subject = subject;
        }
        public void Modify()
        {
            Console.WriteLine($"{subject.SubjectState}被修改，{this.name}做出了反应");
        }
    }
}
