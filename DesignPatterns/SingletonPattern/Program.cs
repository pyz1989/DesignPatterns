using System;
using System.Threading;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------饿汉式-----------");
            Console.WriteLine($"当前时间(主线程)：{DateTime.Now}");
            DBHungry.Show();

            Console.WriteLine("-----------懒汉式-----------");
            DBLazy dbLazy = DBLazy.GetInstance();
            Console.WriteLine($"当前时间(主线程)：{DateTime.Now}");
            dbLazy.Show();
            Console.ReadKey();
        }

        #region 懒汉
        public class DBLazy
        {
            private static DBLazy instance = null;

            private static object lockMe = new object();

            private DBLazy()
            {
                // 模拟：构造函数需要5秒
                System.Threading.Thread.Sleep(5000);
            }

            public static DBLazy GetInstance()
            {
                if (null == instance)
                {
                    lock(lockMe)
                    {
                        if (null == instance)
                        {
                            Console.WriteLine($"线程（{Thread.CurrentThread.ManagedThreadId}）: 准备new实例");
                            instance = new DBLazy();
                        }
                    }
                }
                return instance;
            }

            public void Show()
            {
                Console.WriteLine($"执行当前时间：{DateTime.Now}");
            }
        }
        #endregion

        #region 饿汉
        public class DBHungry
        {
            private static readonly DBHungry instance = new DBHungry();

            private DBHungry()
            {
                // 模拟：构造函数需要5秒
                System.Threading.Thread.Sleep(5000);
            }

            public static DBHungry GetInstance()
            {
                return instance;
            }

            public static void Show()
            {
                Console.WriteLine($"执行当前时间：{DateTime.Now}");
            }
        }
        #endregion
    }
}
