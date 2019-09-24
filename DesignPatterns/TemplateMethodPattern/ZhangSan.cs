using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class ZhangSan: Exam
    {
        public override string Answer()
        {
            return "A";
        }

        public override string Name
        {
            get => "张三";
        }
    }
}
