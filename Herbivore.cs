using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public abstract class Herbivore //травоядное
    {
        public int Weight { get; set; }
        public bool Life { get; set; } = true;
        public Herbivore(int weight)
        {
            Weight = weight;
        }
        public abstract void EatGrass();
        
    }

     class Wildebeest: Herbivore
    {

        public Wildebeest(int Weight): base(Weight) { }
        public override void EatGrass()
        {
            if (Life)
            {
                Weight = +10;
                Console.WriteLine("Wildbeest eat grass" + Weight);
            }
            else throw new Exception("Wildebeest is died");

        }
    }

    class Bison : Herbivore
    {
        public Bison(int Weight): base(Weight) { }
        public override void EatGrass()
        {
            if (Life)
            {
                Weight += 10;
                Console.WriteLine("Bison eat grass" + Weight);

            }
            else throw new Exception("Bison is died");

        }

    }
}
