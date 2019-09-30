using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace StrategyPattern.RealProject
{
    public class StraightSetup : AbstractSetup
    {
        public override void Step(LeafletEntity leaflet, DataRow row)
        {
            // 非顾问
            leaflet.Title = MySqlHelper.GetString(row, "title");
            leaflet.SMSContent = leaflet.CommunicationtypeEnum.HasFlag(CommunicationtypeEnum.短信) ? MySqlHelper.GetString(row, "content") : string.Empty;
            leaflet.EDMContent = leaflet.CommunicationtypeEnum.HasFlag(CommunicationtypeEnum.邮件) ? MySqlHelper.GetString(row, "content") : string.Empty;
            leaflet.MMSContent = leaflet.CommunicationtypeEnum.HasFlag(CommunicationtypeEnum.彩信) ? MySqlHelper.GetString(row, "content") : string.Empty;
            leaflet.SendSMSCount = Convert.ToInt32(row["sendcount"]);
        }
    }
}
