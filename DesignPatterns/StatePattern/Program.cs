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
             * 早上（0:00-12:00）
             * 中午（12:00-14:00）
             * 下午（14:00-18:00）
             * 晚上（18:00-24:00）
             * ---------------------
             */
            DateTime now = DateTime.Now;
            Context context = new Context();

            List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0, len = list.Count; i < len; i++)
            {
                Console.WriteLine(list[i]);
                if (i == 3)
                {
                    list.Remove(list[i]);
                    i--;
                    len--;
                }
            }
            foreach (int i in list)
            {
                Console.WriteLine(i);
                if (i== 3)
                {
                    list.Remove(i);
                }
            }

            context.State = new MorningState();
            Console.ReadKey();
        }
    }
}
