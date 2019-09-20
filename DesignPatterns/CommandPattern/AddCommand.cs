using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class AddCommand : ICommand
    {
        private Received received;
        public AddCommand(Received received)
        {
            this.received = received;
        }
        public void Execute()
        {
            
        }
    }
}
