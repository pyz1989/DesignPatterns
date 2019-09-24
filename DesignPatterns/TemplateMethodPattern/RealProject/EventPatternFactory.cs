using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern.RealProject
{
    public class EventPatternFactory
    {
        protected static Dictionary<int, AbstractEventPattern> patternDic = new Dictionary<int, AbstractEventPattern>()
        {
            { 0, new EventPattern0() },
            { 1, new EventPattern1() },
            { 96, new EventPattern96() },
            { 97, new EventPattern97() },
            { 98, new EventPattern98() },
        };

        /// <summary>
        /// 1. 【1】 日期按照M:d模式，用“,”隔开
        /// 2. 【96】 日期按照M:d模式，用“,”隔开【通过普通的代码获取】
        /// 3. 【97】 普通时间格式
        /// 4. 【98】 日期按照星期一、星期二
        /// 5. 【99】 日期按照1日、15日
        /// </summary>
        /// <param name="patternNum"></param>
        /// <returns></returns>
        public static AbstractEventPattern CreateInstance(int patternNum)
        {
            if (patternDic.ContainsKey(patternNum))
            {
                return patternDic[patternNum];
            }
            // 未知模式，按0处理
            return patternDic[0];
        }
    }
}
