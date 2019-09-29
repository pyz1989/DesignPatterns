using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class ConcreteSubject : ISubject
    {
        List<IObserver> observerList = new List<IObserver>();
        public string SubjectState { get; set; }

        public void Add(IObserver observer)
        {
            this.observerList.Add(observer);
        }

        public void Notify()
        {
            // 异步通知
            foreach (var item in observerList)
            {
                item.Modify();
            }
        }

        public void Remove(IObserver observer)
        {
            this.observerList.Remove(observer);
        }
    }
}
