using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharpquarium
{
    public class Aquarium
    {
        // Used for contain AquaticLifeForm
        private AquaticLifeForm[] location;
        // The limit of the Aquarium
        private int max_size=9;

        public Aquarium()
        {
            this.Location = new AquaticLifeForm[10];
        }
        public Aquarium(int _size)
        {
            this.Max_size= _size-1;
            this.Location = new AquaticLifeForm[Max_size];
        }

        // Used for replace the aquarium by another (loading a save for exemple)
        public Aquarium(Aquarium _copy)
        {
            this.Location = _copy.Location;
            this.Max_size= _copy.Max_size;
        }
        

        internal AquaticLifeForm[] Location { get => location; set => location = value; }
        public int Max_size { get => max_size; set => max_size = value; }

        /// <summary>
        /// Used for add an AquaticLifeForm to the Aquarium
        /// </summary>
        /// <param name="_aquatic_life_form"></param> type AquaticLifeForm
        /// <example>aquarium.AddAquaticLifeForm(fish)</example>
        private void AddAquaticLifeForm(AquaticLifeForm _aquatic_life_form)
        {
            bool ok=false;
            for (int i = 0; i < Max_size; i++)
            {
                if(this.Location[i] == null)
                {
                    this.Location[i] = _aquatic_life_form;
                    i = Max_size;
                    Console.WriteLine("Ajouté a l'emplacement " + i);
                    ok = true;
                }
            }
            if (!ok)
                 Console.WriteLine("Aquarium plein");
        }

        /// <summary>
        /// Used for remove an AquaticLifeForm in the Aquarium, you need to have the index of the object in the location
        /// </summary>
        /// <param name="_index"></param> the index of the AquaticLifeForm
        /// <example>aquarium.RemoveAquaticLifeForm(7)</example>
        public void RemoveAquaticLifeForm(int _index)
        {
            this.Location = this.Location.Where((source,index)=>index !=_index).ToArray();
        }

        /// <summary>
        /// Clean every AquaticLifeForm of the Aquarium
        /// </summary>
        public void RemoveAll()
        {
           this.Location= new AquaticLifeForm[max_size];
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