using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharpquarium
{
    abstract class Fish : AquaticLifeForm
    {
        private Random random= new Random();
        // name of the Fish
        private string name;
        // define the type of SexualityBehavior
        private SexualBehavior sexuality;
        // define the ammount of damage he do when he eat
        private int damage;
        // define the ammount of health point he refill by eating
        private int hp_gain_eat;

        public string Name { get => name; set => name = value; }
        internal SexualBehavior Sexuality { get => sexuality; set => sexuality = value; }
        public Random Random { get => random; set => random = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Hp_gain_eat { get => hp_gain_eat; set => hp_gain_eat = value; }

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

        abstract public AquaticLifeForm ChooseTargetToEat(ref Aquarium _aquarium);

        abstract public AquaticLifeForm ChooseTargetToReproduce(ref Aquarium _aquarium);

        abstract public Fish Reproduce();

        /// <summary>
        /// Only used by Fish , grant an ammount of Fish (used when he eat)
        /// </summary>
        /// <param name="_ammount"></param> int : the ammount of HP refill
        public void GainHP(int _ammount)
        {
            this.Health_point += _ammount;
            if (this.Health_point > 10)
                this.Health_point=10;
        }

    }
}