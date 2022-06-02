using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharpquarium
{
    /// <summary>
    /// Generalyse Hermaphrodite Type
    /// </summary>
    abstract class Hermaphrodite : SexualBehavior
    {
        public void GenderChange()
        {
            if (this.Gender == "Male")
                this.Gender = "Femelle";
            else
                this.Gender = "Male";
        }
    }
}