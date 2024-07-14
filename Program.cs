namespace AnimalWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Continent africa = new Africa();
            List<int> africaHerbivoreWeights = new List<int> { 50, 60 };
            List<int> africaCarnivorePowers = new List<int> { 80, 90 };
            AnimalWorld animalWorldAfrica = new AnimalWorld(africa, africaHerbivoreWeights, africaCarnivorePowers);
            animalWorldAfrica.Run();

            Console.WriteLine("/////////////////////\n");
            Continent America = new NorthAmerica();
            List<int> AmericaHerbivoreWeights = new List<int> { 40, 60 };
            List<int> AmericaCarnivorePowers = new List<int> { 80, 85 };
            AnimalWorld animalWorldAmerica = new AnimalWorld(America, AmericaHerbivoreWeights, AmericaCarnivorePowers);
            animalWorldAmerica.Run();
        }
    }
}
