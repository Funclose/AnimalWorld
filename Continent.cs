using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public abstract class Continent
    {
        public abstract Herbivore CreateHerbivore(int weight);
        public abstract Carnivore CreateCarnivore(int power);
    }
    public class Africa : Continent
    {
        public override Herbivore CreateHerbivore(int weight)
        {
            return new Wildebeest(weight);
        }

        public override Carnivore CreateCarnivore(int power)
        {
            return new Lion(power);
        }
    }


    class NorthAmerica : Continent
    {
        public override Herbivore CreateHerbivore(int weight)
        {
            return new Bison(weight);
        }

        public override Carnivore CreateCarnivore(int power)
        {
            return new Wolf(power);
        }
    }


    class AnimalWorld
    {
        private List<Herbivore> _herbivores;
        private List<Carnivore> _carnivores;

        public AnimalWorld(Continent continent, List<int> herbivoreWeights, List<int> carnivorePowers)
        {
            _herbivores = new List<Herbivore>();
            foreach (var weight in herbivoreWeights)
            {
                _herbivores.Add(continent.CreateHerbivore(weight));
            }

            _carnivores = new List<Carnivore>();
            foreach (var power in carnivorePowers)
            {
                _carnivores.Add(continent.CreateCarnivore(power));
            }
        }

        public void MealsHerbivores()
        {
            foreach (var herbivore in _herbivores)
            {
                herbivore.EatGrass();
            }
        }

        public void NutritionCarnivores()
        {
            foreach (var carnivore in _carnivores)
            {
                foreach (var herbivore in _herbivores)
                {
                    if (herbivore.Life)
                    {
                        carnivore.Eat(herbivore);
                    }
                }
            }
        }

        public void Run()
        {
            MealsHerbivores();
            NutritionCarnivores();
        }
    }
}
