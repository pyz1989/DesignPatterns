using System;
namespace StatePattern
{
    /// <summary>
    /// 状态（抽象类）
    /// </summary>
    public abstract class AbstractState
    {
        public abstract void Handler(Context context);
    }
}
