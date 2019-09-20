using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class RemoveCommand : ICommand
    {
        private Received received;
        public RemoveCommand(Received received)
        {
            this.received = received;
        }
        public void Execute()
        {
            
        }
    }
}
