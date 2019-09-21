using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Sticker : Decorate
    {
        public override void Show()
        {
            Console.WriteLine($"给手机贴膜");
        }
    }
}
