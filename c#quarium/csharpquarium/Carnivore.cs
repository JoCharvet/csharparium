﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharpquarium
{
    
   internal class Carnivore :Fish
    {
        

        public Carnivore()
        {
            this.Age = 0;
            this.Alive = true;
            this.Sexuality = new MonoSexed();
            this.Name = "CarniTest";
            this.Health_point =10;
            this.Species = Spicies_Carnivore.Thon.ToString();
            this.Damage = 4;
            this.Hp_gain_eat = 5;
        }

        public Carnivore(Carnivore _carnivore)
        {
            this.Age = _carnivore.Age;
            this.Alive = _carnivore.Alive;
            this.Sexuality= _carnivore.Sexuality;
            this.Name= _carnivore.Name;
            this.Health_point= _carnivore.Health_point;
            this.Species =_carnivore.Species;
            this.Damage = _carnivore.Damage;
            this.Hp_gain_eat = _carnivore.Hp_gain_eat;
        }

        

        public override AquaticLifeForm ChooseTargetToEat(ref Aquarium _aquarium)
        {
            throw new NotImplementedException();
        }

       

        public override AquaticLifeForm ChooseTargetToReproduce(ref Aquarium _aquarium)
        {
            throw new NotImplementedException();
        }

        public void Eat(Fish _fish)
        {
            throw new System.NotImplementedException();
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