using System;
namespace StatePattern
{
    /// <summary>
    /// 上下文
    /// </summary>
    public class Context
    {
        private AbstractState state;

        public AbstractState State
        {
            get => state;
            set
            {
                state = value;
                Console.WriteLine($"当前的状态：{State.GetType().Name}");
            }
        }
        private int hour;
        /// <summary>
        /// 小时
        /// </summary>
        public int Hour { get => hour; set => hour = value; }

        public void Request()
        {
            this.State.Handler(this);
        }
    }
}
