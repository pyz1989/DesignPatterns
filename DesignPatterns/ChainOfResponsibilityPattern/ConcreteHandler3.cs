using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class ConcreteHandler3 : AbstractHandler
    {
        public override void Request(int state)
        {
            if (state > 7)
            {
                Console.WriteLine($"当前申请请假天数：{state}，已被部门老大同意");
                return;
            }
            if (null != this.handler)
            {
                this.handler.Request(state);
            }
        }
    }
}
