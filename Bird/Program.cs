using System;

namespace Bird // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck(){Kind =KindOfDuck.Mallard,Size=17 },
                new Duck(){Kind=KindOfDuck.Muscovy,Size=18},
                new Duck(){Kind=KindOfDuck.Decoy,Size=14},
                new Duck(){Kind=KindOfDuck.Muscovy,Size = 11},
                new Duck(){Kind=KindOfDuck.Mallard,Size=14},
                new Duck(){Kind=KindOfDuck.Decoy,Size=13},
            };
            IEnumerable<Bird> upcastDucks = ducks;
            List<Bird> birds = new List<Bird>();

            birds.Add(new Bird() { Name = "Feathers" });
            birds.AddRange(upcastDucks);
            birds.Add(new Bird() { Name = "George" });
            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird);
            }
        }
    }
}
