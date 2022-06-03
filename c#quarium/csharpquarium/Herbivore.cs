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
            this.Damage = 3;
            this.Hp_gain_eat = 3;
        }
        /// <summary>
        /// used for clone an Herbivore
        /// </summary>
        /// <param name="_herbivore"></param>type : Herbivore
        public Herbivore(Herbivore _herbivore)
        {
            this.Alive = _herbivore.Alive;
            this.Sexuality = _herbivore.Sexuality;
            this.Species=_herbivore.Species;
            this.Age=_herbivore.Age;
            this.Health_point = _herbivore.Health_point;
            this.Name= _herbivore.Name;
            this.Damage = _herbivore.Damage;
            this.Hp_gain_eat = _herbivore.Hp_gain_eat;
        }
        
        /// <summary>
        /// Used for the herbivore eat a plant, he recieve some healtpoint and the Plant loose some healthpoint
        /// </summary>
        /// <param name="_plant"></param>type : Plant 
        public void Eat(ref Plant _plant)
        {  
            _plant.LooseHP(Damage);
            this.GainHP(Hp_gain_eat);   
        }

        /// <summary>
        /// Used for the herbivore for randomly choose a Plant to eat 
        /// </summary>
        /// <param name="_aquarium"></param>type : Aquarium
        /// <returns>a Plant item</returns>
        public override AquaticLifeForm ChooseTargetToEat( ref Aquarium _aquarium)
        {
            int cpt = 0;
            int num = 0;
            foreach (AquaticLifeForm item in _aquarium.Location)
            {
                if(item.GetType().ToString() == "csharpquarium.Plant")
                cpt++;
            }

            num =this.Random.Next(0,cpt+1);
            cpt = 0;

            foreach  (AquaticLifeForm item in _aquarium.Location)
            {
                if (item.GetType().ToString() == "csharpquarium.Plant")
                {
                    if (cpt == num)
                    {
                        return item;
                    }
                    cpt++;
                }
               
            }
            return new Plant();
        }

        public override AquaticLifeForm ChooseTargetToReproduce(ref Aquarium _aquarium)
        {
            int cpt = 0;
            int num ;
            foreach (AquaticLifeForm item  in _aquarium.Location)
            {            
                    if (item.GetType() == this.GetType() && ((Fish)item).Sexuality.Gender != this.Sexuality.Gender)
                        cpt++;    
            }
            num = this.Random.Next(0, cpt + 1);
            cpt = 0;

            foreach (AquaticLifeForm item in _aquarium.Location)
            {
                if (item.GetType() == this.GetType() && ((Fish)item).Sexuality.Gender != this.Sexuality.Gender)
                {
                    if (cpt == num)
                    {
                        return item;
                    }
                    cpt++;
                }

            }
            return new Herbivore();
        }

        public override void LiveATurn(Aquarium _aquarium)
        {
            throw new NotImplementedException();
        }

        public override Fish Reproduce()
        {
            throw new NotImplementedException();
        }
    }
}