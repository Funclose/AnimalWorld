using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public abstract class Carnivore //плотоядное
    {
        public int Power { get; set; }

        public Carnivore(int power)
        {
            Power = power;
        }

        public abstract void Eat(Herbivore obj);


    }

    public class Lion : Carnivore
    {
        public Lion(int Power) : base(Power) { }
        public override void Eat(Herbivore obj)
        {

            if (Power > obj.Weight)
            {
                Power = +10;
                Console.WriteLine("lion eat Herbivore" + Power);
                obj.Life = false;
            }

            else
            {
                Power -=10;
                Console.WriteLine("wolf does't eat");

            }
        }
    }

    public class Wolf : Carnivore
    {
        public Wolf(int Power) : base(Power) { }

        public override void Eat(Herbivore obj)
        {
            if (Power > obj.Weight)
            {
                Power = +10;
                Console.WriteLine("Wolf eat Herbivore" + Power);
                obj.Life = false;
            }

            else
            {
                Power -= 10;
                Console.WriteLine("wolf does't eat");
            }
        }
    }



}
