using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class FatPerson : AbstractPerson
    {
        public override void CreateBody()
        {
            Console.WriteLine("胖人的身体");
        }

        public override void CreateHand()
        {
            Console.WriteLine("胖人的手");
        }

        public override void CreateHead()
        {
            Console.WriteLine("胖人的头");
        }

        public override void CreateLeg()
        {
            Console.WriteLine("胖人的腿");
        }
    }
}
