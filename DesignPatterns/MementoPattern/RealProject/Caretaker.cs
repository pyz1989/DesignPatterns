using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.RealProject
{
    public class Caretaker
    {
        public List<Memento> MementoList { get; set; } = new List<Memento>();
    }
}
