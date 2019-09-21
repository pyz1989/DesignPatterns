using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class ConcreteHandler2 : AbstractHandler
    {
        public override void Request(int state)
        {
            if (state <= 7)
            {
                Console.WriteLine($"当前申请请假天数：{state}，已被研发经理同意");
                return;
            }
            if (null != this.handler)
            {
                this.handler.Request(state);
            }
        }
    }
}
