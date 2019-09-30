using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class StrategyContext
    {
        AbstractLog log = null;

        public StrategyContext()
        {
            log = new FileLog();
        }

        public StrategyContext(AbstractLog log)
        {
            this.log = log;
        }

        public void Write(string msg)
        {
            try
            {
                log.Write(msg);
            }
            catch (Exception)
            {
                log = new DBLog();
                log.Write(msg);
            }
        }
    }
}
