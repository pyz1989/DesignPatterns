using System;
using System.Collections.Generic;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 状态模式（State Pattern）
             * 
             * 如下划分早上、中午、下午、晚上四个时间段（状态）
             * ---------------------
             * 早上（0-12）
             * 中午（12-14）
             * 下午（14-18）
             * 晚上（18-24）
             * ---------------------
             */
            Context context = new Context()
            {
                State = new MorningState(),
                Hour = 23
            };
            context.Request();
            Console.ReadKey();
        }
    }
}
