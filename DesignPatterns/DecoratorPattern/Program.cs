using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 手机
            Phone phone = new ApplePhone();

            Decorate sticker = new Sticker();
            Decorate accessories = new Accessories();
            // 贴膜
            sticker.SetDecorate(phone);
            // 配件
            accessories.SetDecorate(sticker);
            accessories.Show();
            Console.ReadKey();
        }
    }
}
