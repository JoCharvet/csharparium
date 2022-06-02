using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharpquarium
{
    internal class Plant : AquaticLifeForm
    {
        internal Plant()
        {
            this.Alive = true;
            this.Age = 0;
            this.Health_point = 10;
            this.Species = "Algues";
         
        }

        public Plant Duplicate()
        {
            return new Plant();
        }

        public override void Display()
        {
            Console.WriteLine("Plante - Age : " + this.Age + "  espèce : " + this.Species + "  HP : " + this.Health_point);
        }
    }
}