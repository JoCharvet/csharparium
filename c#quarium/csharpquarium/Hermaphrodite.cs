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
        public void GenderChange(ref string _gender)
        {
            if (_gender == "Male")
                _gender = "Femelle";
            else
                _gender = "Male";
        }
    }
}