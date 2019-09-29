using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class BuilderDirector
    {
        AbstractPerson person = null;

        public BuilderDirector(AbstractPerson person)
        {
            this.person = person;
        }
        /// <summary>
        /// 这里面封装子组件的流程是【不易变的】
        /// </summary>
        public void CreatePerson()
        {
            this.person.CreateHead();
            this.person.CreateBody();
            this.person.CreateHand();
            this.person.CreateLeg();
        }
    }
}
