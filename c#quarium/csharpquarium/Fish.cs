using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharpquarium
{
    abstract class Fish : AquaticLifeForm
    {
        // name of the Fish
        private string name;
        // define the type of SexualityBehavior
        private SexualBehavior sexuality;

        public string Name { get => name; set => name = value; }
        internal SexualBehavior Sexuality { get => sexuality; set => sexuality = value; }

        public void Eat()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// used for display information of all Fish
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("Prénom : "+this.Name + " Age : " + this.Age + "  Espèce : " + this.Species + "  HP : " + this.Health_point);
        }
    }
}