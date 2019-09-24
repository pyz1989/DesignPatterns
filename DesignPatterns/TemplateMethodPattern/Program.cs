using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam zhangSan = new ZhangSan();


            Console.WriteLine(DateTime.Now.ToString("M:d"));
            Exam liSi = new LiSi();
            zhangSan.Questions();
            liSi.Questions();
            Console.ReadKey();
        }
    }
}
