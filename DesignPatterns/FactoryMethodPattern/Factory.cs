using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class Factory
    {
        public static Database CreateInstance(string dbType)
        {
            Console.WriteLine($"创建数据库{dbType}...");
            switch (dbType)
            {
                case "SqlLite":
                    return new SqlLite();
                case "MySql":
                    return new MySql();
                case "SqlServer":
                    return new SqlServer();
                default:
                    break;
            }
            throw new ArgumentException("参数错误：dbType = {dbType}");
        }
    }
}
