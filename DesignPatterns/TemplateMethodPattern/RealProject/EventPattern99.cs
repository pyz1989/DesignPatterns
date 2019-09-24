using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern.RealProject
{
    public class EventPattern99: AbstractEventPattern
    {
        public override bool IsAdvisercreateEvent { get => true; }

        public override List<MarketCustomerModel> GetCustomerList(LeafletEntity leaflet, DataRow row)
        {
            return base.GetCustomerList(leaflet, row);
        }

        public override bool IsContains(DataRow row)
        {
            var day = string.Format("{0}日", DateTime.Now.Day);

            var dayList = MySqlHelper.GetString(row, "executedays");

            var isContain = dayList.Split(",").Contains(day);

            return isContain;
        }
    }
}
