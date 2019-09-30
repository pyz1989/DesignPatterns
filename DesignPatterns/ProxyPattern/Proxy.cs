using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class Proxy : AbstractDatabase
    {
        SqlServer sqlServer = new SqlServer();

        public override void Add()
        {
            sqlServer.Add();
        }

        public override void Remove()
        {
            sqlServer.Remove();
        }
    }
}
