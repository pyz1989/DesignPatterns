using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator()
            {
                Status = "张三",
                OtherStatus = "你好"
            };


            Caretaker caretaker = new Caretaker()
            {
                Memento = originator.CreateMemento()
            };
            // 修改
            originator.Status = "李四";
            Console.WriteLine($"修改后的值：{originator.Status}");
            // 撤销
            originator.RecoveryMemento(caretaker.Memento);
            Console.WriteLine($"赋值错误，修复中...");
            Console.WriteLine($"撤销已完成：{originator.Status}");
            Console.ReadKey();
        }
    }
}
