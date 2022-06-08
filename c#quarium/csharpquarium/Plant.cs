using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharpquarium
{
    internal class Plant : AquaticLifeForm
    {
        /// <summary>
        /// Constructor by default
        /// </summary>
        internal Plant()
        {
            this.Alive = true;
            this.Age = 0;
            this.Health_point = 10;
            this.Species = "Algues";
        }
        /// <summary>
        /// Clone constructor
        /// </summary>
        /// <param name="_plant"></param>type Plant
        internal Plant(Plant _plant)
        {
            this.Alive = _plant.Alive;
            this.Age = _plant.Age;
            this.Health_point = _plant.Health_point;
            this.Species = _plant.Species;
        }

        /// <summary>
        /// Used by a plant for duplicate her, only when she have 10 healthpoint
        /// </summary>
        /// <returns></returns>
        public Plant Duplicate()
        {

            return new Plant(this);
        }

        /// <summary>
        /// Used for display age, spicies and healthpoint of the plant
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("Plante - Age : " + this.Age + "  espèce : " + this.Species + "  HP : " + this.Health_point);
        }


        public override void LiveATurn(ref Aquarium _aquarium)
        {
            
            if (this.Age < 20)
            {
                this.GainHP();
                if (this.Health_point == 10)
                {
                    if (_aquarium.Location.Count < _aquarium.Max_size)
                    {
                        this.LooseHP((this.Health_point / 2));
                        _aquarium.AddAquaticLifeForm(this.Duplicate());
                    }

                }
            }
            else
            {
                this.Alive = false;
            }

        }
    }
}