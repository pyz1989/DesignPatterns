using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class Colleage : AbstractColleague
    {
        AbstractMediator mediator = null;
        public Colleage(string userName, AbstractMediator mediator)
        {
            this.UserName = userName;
            this.mediator = mediator;
        }

        public override void Receive(string message)
        {
            Console.WriteLine(message);
        }

        public override void Send(string userName, string message)
        {
            this.mediator.Send(userName, message);
        }
    }
}
