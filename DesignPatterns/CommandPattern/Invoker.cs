using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Invoker
    {
        private List<ICommand> commandList = new List<ICommand>();

        public void SetCommand(ICommand command)
        {
            commandList.Add(command);
        }


        public void Execute()
        {
            foreach (ICommand command in commandList)
            {
                command.Execute();
            }
        }
        /// <summary>
        /// 撤销（删除命令列表中的最后一条命令）
        /// </summary>
        public void UnDo()
        {
            if (commandList.Count > 0)
            {
                this.commandList.RemoveAt(commandList.Count - 1);
            }
        }
    }
}
