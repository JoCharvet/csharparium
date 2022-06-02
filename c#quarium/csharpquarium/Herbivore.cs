using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharpquarium
{
   internal class Herbivore:Fish
    {
        /// <summary>
        /// Constructor by default
        /// </summary>
        public Herbivore()
        {
            this.Alive = true;
            this.Sexuality = new MonoSexed();
            this.Species = "Carpes";
            this.Age = 0;
            this.Health_point = 10;
            this.Name = "test";
        }
        /// <summary>
        /// used for clone an Herbivore
        /// </summary>
        /// <param name="_herbivore"></param>
        public Herbivore(Herbivore _herbivore)
        {
            this.Alive = _herbivore.Alive;
            this.Sexuality = _herbivore.Sexuality;
            this.Species=_herbivore.Species;
            this.Age=_herbivore.Age;
            this.Health_point = _herbivore.Health_point;
            this.Name= _herbivore.Name;
        }
        

        public void Eat(Plant _plant)
        {
            throw new System.NotImplementedException();
        }
    }
}