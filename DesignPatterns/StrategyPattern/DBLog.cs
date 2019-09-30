using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class DBLog: AbstractLog
    {
        public override void Write(string msg)
        {
            Console.WriteLine($"日志记录到( DB )：{msg}");
        }
    }
}
