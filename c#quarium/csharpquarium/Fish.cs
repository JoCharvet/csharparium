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
        // define the gender of a fish
        private string gender;

        public string Name { get => name; set => name = value; }
        internal SexualBehavior Sexuality { get => sexuality; set => sexuality = value; }
        public Random Random { get => random; set => random = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Hp_gain_eat { get => hp_gain_eat; set => hp_gain_eat = value; }
        public string Gender { get => gender; set => gender = value; }

        public void Eat(ref AquaticLifeForm _alf)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// used for display information of all Fish
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("Prénom : "+this.Name +" Sexe : "+ this.Gender +" Age : " + this.Age + "  Espèce : " + this.Species + "  HP : " + this.Health_point);
        }

        /// <summary>
        /// Used b for randomly choose a Plant to eat 
        /// </summary>
        /// <param name="_aquarium"></param>type : Aquarium
        /// <returns>a Plant item</returns>
        public  AquaticLifeForm? ChooseTargetToEat(ref Aquarium _aquarium)
        {
            int cpt = 0;
            int num = 0;
            foreach (AquaticLifeForm item in _aquarium.Location)
            {
                if (item.GetType().ToString() == "csharpquarium.Plant")
                    cpt++;
            }

            num = this.Random.Next(0, cpt + 1);
            cpt = 0;

            foreach (AquaticLifeForm item in _aquarium.Location)
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
            return null;
        }

        /// <summary>
        /// Used by a Fish for randomly choose a Fish of his species for making a baby
        /// </summary>
        /// <param name="_aquarium"></param>type : Aquarium by ref
        /// <returns>a Fish</returns>
        public AquaticLifeForm? ChooseTargetToReproduce(ref Aquarium _aquarium)
        {
            int cpt = 0;
            int num;
            foreach (AquaticLifeForm item in _aquarium.Location)
            {
                if (item.GetType() == this.GetType() && ((Fish)item).Gender != this.Gender && this.Species == item.Species)
                    cpt++;
            }
            num = this.Random.Next(0, cpt + 1);
            cpt = 0;

            foreach (AquaticLifeForm item in _aquarium.Location)
            {
                if (item.GetType() == this.GetType() && ((Fish)item).Gender != this.Gender && this.Species == item.Species)
                {
                    if (cpt == num)
                    {
                        return item;
                    }
                    cpt++;
                }
            }
            return null;
        }

        abstract public Fish? Reproduce(Fish _fish);

        /// <summary>
        /// Only used by Fish , grant an ammount of healtpoint (used when he eat)
        /// </summary>
        public void GainHPByEating()
        {
            this.Health_point += this.Hp_gain_eat;
            if (this.Health_point > this.Max_hp)
                this.Health_point=this.Max_hp;
        }

        public string ChooseAName()
        {
            int choice;
            string name="";
            this.random = new Random();
            choice = this.random.Next(0, 10);

            if (this.sexuality is Hermaphrodite)
            {
                name = Enum.GetNames(typeof(FirstNameMixed))[choice].ToString();
            }
            else
            {
                if (this.gender == "femelle")
                {
                    name = Enum.GetNames(typeof(FirstNameFemale))[choice].ToString();
                }
                else
                {
                    name = Enum.GetNames(typeof(FirstNameMale))[choice].ToString();
                }
            }
            return name ;
        }


    }
}