using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace StrategyPattern.RealProject
{
    public class RandSetup: AbstractSetup
    {
        EventMarketingBLLNew eventMarketingBLLNew = new EventMarketingBLLNew();
        public override void Step(LeafletEntity leaflet, DataRow row)
        {
            var communicationInfo = new LeafletEntity(); // 数据获取
            if (leaflet.CommunicationtypeEnum.HasFlag(CommunicationtypeEnum.彩信))
            {
                leaflet.MMSContent = communicationInfo.MMSContent;
            }
            throw new NotImplementedException();
        }
    }
}
