using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyContext strategyContext = new StrategyContext();
            strategyContext.Write("简单消息");
            strategyContext.Write("复杂消息：捕获到一个未知的异常！");
            Console.ReadKey();
        }
    }
}
