using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace StrategyPattern.RealProject
{
    public class StrategyContext
    {
        AbstractSetup setup = null;

        public StrategyContext(AbstractSetup setup)
        {
            this.setup = setup;
        }

        public void Setup(LeafletEntity leaflet, DataRow row)
        {
            this.setup.Step(leaflet, row);
        }
    }
}
    