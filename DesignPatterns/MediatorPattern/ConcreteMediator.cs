using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    public class ConcreteMediator : AbstractMediator
    {
        private List<AbstractColleague> colleagues = new List<AbstractColleague>();
        public override void Add(AbstractColleague colleague)
        {
            this.colleagues.Add(colleague);
        }

        /// <summary>
        /// 通过userName从QQ列表中找到指定的人，然后转发
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="message">消息</param>
        public override void Send(string userName, string message)
        {
            var single = colleagues.FirstOrDefault(c => c.UserName == userName);
            if (null != single)
            {
                single.Receive($"{userName}：{message}");
            }
        }
    }
}
