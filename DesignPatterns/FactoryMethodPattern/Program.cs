using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();
            string dbType = configuration.GetSection("dbType").Value;

            Database db1 = Factory.CreateInstance(dbType);
            Database db2 = Factory.CreateInstance(dbType);
            Database db3 = Factory.CreateInstance(dbType);
            Database db4 = Factory.CreateInstance(dbType);
            Console.ReadKey();
        }
    }
}
