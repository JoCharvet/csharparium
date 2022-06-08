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
            this.Max_hp = 10;
            this.Damage = 3;
            this.Hp_gain_eat = 3;
            this.Name = this.ChooseAName();
        }
        /// <summary>
        /// used for have a baby Herbivore with same attribute except age
        /// </summary>
        /// <param name="_herbivore"></param>type : Herbivore
        public Herbivore(Herbivore _herbivore)
        {
            this.Alive = _herbivore.Alive;
            this.Sexuality = _herbivore.Sexuality;
            this.Species=_herbivore.Species;
            this.Age=0;
            this.Health_point = _herbivore.Health_point;
            this.Name= _herbivore.Name;
            this.Damage = _herbivore.Damage;
            this.Hp_gain_eat = _herbivore.Hp_gain_eat;
        }
        
        /// <summary>
        /// Used for the herbivore eat a plant, he recieve some healtpoint and the Plant loose some healthpoint
        /// </summary>
        /// <param name="_plant"></param>type : Plant 
        public void Eat( AquaticLifeForm? _plant)
        {  
            if( _plant != null)
            {
                _plant.LooseHP(this.Damage);
                this.GainHPByEating();
            }
           
        }

       



        public override void LiveATurn( ref Aquarium _aquarium)
        {
            this.Age++;
            if (this.Age>=20)
            {
                this.Die();
            }
            else
            {
                if (this.Health_point <= 5)
                {
                    this.Eat(this.ChooseTargetToEat(ref _aquarium));
                }
                else if (this.Health_point == Max_hp)
                {
                    _aquarium.AddAquaticLifeForm(this.Reproduce((Fish)this.ChooseTargetToReproduce(ref _aquarium)));
                }
            }
            this.Display();
            
        }

        public override Fish? Reproduce(Fish? _fish)
        {
            if (_fish == null)
            {
                return null;
            }
            else
            {
                return new Herbivore(this);
            }
            
        }
    }
}