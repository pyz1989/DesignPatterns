using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 中午
    /// </summary>
    public class NoonState:AbstractState
    {
        public override void Handler(Context context)
        {
            if (context.Hour >= 12 && context.Hour < 14)
            {
                Console.WriteLine("中午好...");
                return;
            }
            context.State = new AfternoonState();
            context.Request();
        }
    }
}
