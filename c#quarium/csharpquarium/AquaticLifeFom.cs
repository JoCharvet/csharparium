using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharpquarium
{
    /// <summary>
    ///  Generalize all life forms can you put in aquarium
    /// </summary>
    abstract class AquaticLifeForm
    {
        // Use for set the number of healtpoint of an Aquaticlifeform
        private int health_point =10;

        private int max_hp= 10;
        // the sepcies of an AquaticLifeForm
        private string species;

        // the size of an AquaticLifeForm if upgrade
        //private int size;

        // for know if the AquaticLifeForm are alive ?
        private bool alive;

        // Use for set the age of an AquaticLifeForm
        private int age=0;

        // Set the maximum turn the AquaticLifeForm can sruvive
        private int limit_age;

        
        public int Health_point { get => health_point; set => health_point = value; }
        public string Species { get => species; set => species = value; }
        
        //public int Size { get => size; set => size = value; }
        public int Age { get => age; set => age = value; }
        public bool Alive { get => alive; set => alive = value; }
        public int Limit_age { get => limit_age; set => limit_age = value; }

        

        public int Max_hp { get => max_hp; set => max_hp = value; }

        /// <summary>
        /// Used for loosing health point, -1 hp, if no more hp call Die()
        /// </summary>
        public void LooseHP()
        {
            this.Health_point--;
            if (this.Health_point<1)
            {
                this.Die();
            }
        }

        /// <summary>
        /// Used for loosing health point,depends of the fish who attack him, if no more hp call Die()
        /// </summary>
        /// <param name="_damage"></param>the amount of damage
        public void LooseHP(int _damage)
        {
            this.Health_point=this.Health_point-_damage;
            if (this.Health_point < 1)
            {
                this.Die();
            }
        }

        /// <summary>
        ///  Used for add health point can add more than the HP limit
        /// </summary>
        public void GainHP()
        {
            if (this.Health_point <this.Max_hp)
            this.Health_point++;       
        }

        /// <summary>
        /// Something was wrong with this AquaticLiveForm, he doesn't move anymore 
        /// </summary>
        public void Die()
        {
           this.Alive = false;
        }

        /// <summary>
        /// Abstract Method for Display an AquaticLifeForm used by LiveATurn method
        /// </summary>
        abstract public void Display();

        /// <summary>
        /// Abstract Method for an AquaticLifeForm live a turn 
        /// </summary>
        /// <param name="_aquarium"></param>Type Aquarium by ref
        abstract public void LiveATurn( ref Aquarium _aquarium);
      
    }
}