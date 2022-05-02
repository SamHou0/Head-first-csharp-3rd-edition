using System;

namespace List_Practice // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shoe> shoeCloset = new();
            shoeCloset.Add(new Shoe() { Style = Style.Sneakers, Color = "Black" });
            shoeCloset.Add(new Shoe() { Style = Style.Clogs, Color = "Brown" });
            shoeCloset.Add(new Shoe() { Style = Style.Wingtips, Color = "Black" });
            shoeCloset.Add(new Shoe() { Style = Style.Loafers, Color = "White" });
            shoeCloset.Add(new Shoe() { Style = Style.Loafers, Color = "Red" });
            shoeCloset.Add(new Shoe() { Style = Style.Sneakers, Color = "Green" });

            int numberOfShoes = shoeCloset.Count;
            foreach (Shoe shoe in shoeCloset)
            {
                shoe.Style = Style.Flipflops;
                shoe.Color = "Orange";
            }


            shoeCloset.RemoveAt(4);

            Shoe thirdShoe = shoeCloset[2];
            Shoe secondShoe=shoeCloset[1];
            shoeCloset.Clear();

            shoeCloset.Add(thirdShoe);
            if (shoeCloset.Contains(secondShoe))
            {
                Console.WriteLine("That's surprising.");
            }
            List<Shoe> list = shoeCloset.ToList();
            List<List<List<List<List<List<List<List<int>>>>>>>> lists = new();
        }
    }
}
