﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern.RealProject
{
    public abstract class AbstractEventPattern
    {
        private JobMarketingHelper jobMarketingHelper = new JobMarketingHelper();

        // 获取客户数
        public virtual List<MarketCustomerModel> GetCustomerList(LeafletEntity leaflet, DataRow row)
        {
            var marketingCustomerList = jobMarketingHelper.GetMarketingCustomerByEventQuery(leaflet.ShopID,
                MySqlHelper.GetString(row, "analyzecondition"),
                IsAdvisercreateEvent,
                leaflet.CommunicationtypeEnum
            ) ?? new List<MarketCustomerModel>();
            return marketingCustomerList;
        }
        public virtual bool IsAdvisercreateEvent { get; set; }

        public virtual bool IsContains(DataRow row)
        {
            var nowDate = DateTime.Now.ToString("M:d");
            var days = MySqlHelper.GetString(row, "executedays");
            var isContain = days.Split(',').Contains(nowDate);
            return isContain;
        }
    }
}
