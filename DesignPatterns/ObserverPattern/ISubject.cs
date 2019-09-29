using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface ISubject
    {
        string SubjectState { get; set; }

        void Add(IObserver observer);

        void Notify();

        void Remove(IObserver observer);
    }
}
