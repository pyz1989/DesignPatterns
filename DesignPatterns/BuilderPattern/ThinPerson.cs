using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class ThinPerson : AbstractPerson
    {
        public override void CreateBody()
        {
            Console.WriteLine("瘦人的身体");
        }

        public override void CreateHand()
        {
            Console.WriteLine("瘦人的手");
        }

        public override void CreateHead()
        {
            Console.WriteLine("瘦人的头");
        }

        public override void CreateLeg()
        {
            Console.WriteLine("瘦人的腿");
        }
    }
}
