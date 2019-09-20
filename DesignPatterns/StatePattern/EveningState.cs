using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 晚上
    /// </summary>
    public class EveningState:AbstractState
    {
        public override void Handler(Context context)
        {
            if (context.Hour >= 18 && context.Hour < 24)
            {
                Console.WriteLine("晚上好...");
                return;
            }
            context.State = new MorningState();
            context.Request();
        }
    }
}
