using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.RealProject
{
    public class Leaflet
    {
        public List<int> CustomerList { get; set; }

        public DateTime ExecuteTime { get; set; }

        public int LeafletID { get; set; }

        public int SendType { get; set; }

        public Memento CreateMemento()
        {
            return new Memento()
            {
                CustomerList = new List<int>(),
                LeafletID = new Random().Next(0, 100),
            };
        }
        public void RecoveryMemento(Memento memento)
        {
            this.CustomerList = memento.CustomerList;
        }
    }
}
