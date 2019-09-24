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
