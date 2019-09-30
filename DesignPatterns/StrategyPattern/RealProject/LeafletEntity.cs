using System;

namespace StrategyPattern.RealProject
{
    public class LeafletEntity
    {
        public int ShopID { get; set; }
        public string Title { get; set; }
        public CommunicationtypeEnum CommunicationtypeEnum { get; set; }


        public string SMSContent { get; set; }
        public string EDMContent { get; set; }
        public string MMSContent { get; set; }
        public int SendSMSCount { get; set; }
    }
}