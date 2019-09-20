using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 早上
    /// </summary>
    public class MorningState: AbstractState
    {
        public override void Handler(Context context)
        {
            if (context.Hour >= 0 && context.Hour < 12)
            {
                Console.WriteLine("早上好...");
                return;
            }
            context.State = new NoonState();
            context.Request();
        }
    }
}
