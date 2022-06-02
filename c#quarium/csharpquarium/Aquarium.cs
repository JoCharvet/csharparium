using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharpquarium
{
    public class Aquarium
    {
        // Used for contain AquaticLifeForm
        List <AquaticLifeForm> location;
        // The limit of the Aquarium
        private int max_size=9;

        public Aquarium()
        {
            this.Location = new List<AquaticLifeForm>();
        }
        public Aquarium(int _size)
        {
            this.Max_size= _size-1;
            this.Location = new List<AquaticLifeForm>();
        }

        // Used for replace the aquarium by another (loading a save for exemple)
        public Aquarium(Aquarium _copy)
        {
            this.Location = _copy.Location;
            this.Max_size= _copy.Max_size;
        }
        
        internal List<AquaticLifeForm> Location { get => location; set => location = value; }
        public int Max_size { get => max_size; set => max_size = value; }

        /// <summary>
        /// Used for add an AquaticLifeForm to the Aquarium
        /// </summary>
        /// <param name="_aquatic_life_form"></param> type AquaticLifeForm
        /// <example>aquarium.AddAquaticLifeForm(fish)</example>
        private void AddAquaticLifeForm(AquaticLifeForm _aquatic_life_form)
        { 
            if(this.Location.Count < this.Max_size)
               this.Location.Add(_aquatic_life_form);
            else
               Console.WriteLine("Aquarium plein.");
        }

        /// <summary>
        /// Used for remove an AquaticLifeForm in the Aquarium, you need to have the index of the object in the location
        /// </summary>
        /// <param name="_aquatic_life_form"></param> type AquaticLifeForm
        /// <example>aquarium.RemoveAquaticLifeForm(7)</example>
        internal void RemoveAquaticLifeForm(AquaticLifeForm _aquaticLifeForm)
        {
            this.location.Remove(_aquaticLifeForm);
            //this.Location = this.Location.Where((source,index)=>index !=_index).ToArray();
        }

        /// <summary>
        /// Clean every AquaticLifeForm of the Aquarium
        /// </summary>
        public void RemoveAll()
        {
           this.Location= new List<AquaticLifeForm>();
        }

        /// <summary>
        /// Used for ask to each AquaticLifeForm in the Aquarium to present themselves
        /// </summary>
        public void DisplayAquarium()
        {
            foreach (var item in this.Location)
            {
                item.Display();
            }
        }

        public void Turn()
        {

        }
    }
}