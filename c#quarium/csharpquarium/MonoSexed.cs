using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharpquarium
{
    internal class MonoSexed : SexualBehavior
    {
        public MonoSexed() : base()
        {
        }

        public MonoSexed(string _sexe) :base(_sexe)
        {
        }
    }
}