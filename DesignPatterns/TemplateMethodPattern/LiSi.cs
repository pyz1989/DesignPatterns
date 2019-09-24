using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class LiSi: Exam
    {
        public override string Answer()
        {
            return "B";
        }

        public override string Name
        {
            get => "李四";
        }
    }
}
