using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam zhangSan = new ZhangSan();
            Exam liSi = new LiSi();
            zhangSan.Questions();
            liSi.Questions();
            Console.ReadKey();
        }
    }
}
