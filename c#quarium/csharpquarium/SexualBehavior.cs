using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharpquarium
{
    abstract class SexualBehavior
    {
        private string gender;

        protected SexualBehavior()
        {
            this.Gender = "femelle";
        }

        protected SexualBehavior( string _sexe)
        {
            this.Gender = _sexe;
        }

        public string Gender { get => gender; set => gender = value; }

         
    }
}