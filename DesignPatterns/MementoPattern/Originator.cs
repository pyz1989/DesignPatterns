using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    public class Originator
    {
        public string Status { get; set; }
        public string OtherStatus { get; set; }
        /// <summary>
        /// 创建备忘录：【生成快照方法】
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            return new Memento()
            {
                Status = this.Status
            };
        }

        public void RecoveryMemento(Memento memento)
        {
            this.Status = memento.Status;
        }
    }
}
