using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Worker
    {
        private string name;
        private List<Animal> animalsToLookAfter;

        public Worker(string name, List<Animal> animalsToLookAfter)
        {
            this.name = name;
            this.animalsToLookAfter = animalsToLookAfter;
        }

        public Worker(string name)
        {
            this.name = name;
            this.animalsToLookAfter = new List<Animal>();
        }

        public void SetAnimalsToLookAfter(List<Animal> animals)
        {
            this.animalsToLookAfter = animals;
        }

        public void DoDailyRoutine()
        {
            foreach (Animal animal in animalsToLookAfter)
            {
                if (animal.IsHungry())
                {
                    animal.Eat();
                }
            }
        }
    }
}
