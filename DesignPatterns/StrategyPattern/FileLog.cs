using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class FileLog: AbstractLog
    {
        public override void Write(string msg)
        {
            if (msg != null && msg.Length > 10)
            {
                throw new Exception("信息超长");
            }
            Console.WriteLine($"日志记录到(File)：{msg}");
        }
    }
}
