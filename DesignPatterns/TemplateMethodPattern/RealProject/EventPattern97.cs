using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TemplateMethodPattern.RealProject
{
    public class EventPattern97: AbstractEventPattern
    {
        public override bool IsAdvisercreateEvent { get; set; }

        public override List<MarketCustomerModel> GetCustomerList(LeafletEntity leaflet, DataRow row)
        {
            return base.GetCustomerList(leaflet, row);
        }

        public override bool IsContains(DataRow row)
        {
            return base.IsContains(row);
        }
    }
}
