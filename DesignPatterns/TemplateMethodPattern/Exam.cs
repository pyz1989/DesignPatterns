using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public abstract class Exam
    {
        public virtual string Name { get; set; }

        public void Questions()
        {
            Console.WriteLine($"{Name}：今天暖和吗？ {Answer()}");
        }

        public virtual string Answer()
        {
            return string.Empty;
        }
    }
}
