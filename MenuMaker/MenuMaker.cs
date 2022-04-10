using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaker
{
    internal class MenuMaker
    {
        public Random Randomizer = new Random();

        private string[] Meats = { "Roast Beef", "Salami", "Turkey", "Ham", "Pastrami" };
        private string[] Condiments = { "yellow mustard", "brown mustand", "honey mustand", "mayo", "relish", "french dressing" };
        private string[] Breads = { "rye", "white", "wheat", "pumpernickel", "italian bread", "a roll" };

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + " with " + randomCondiment + " on " + randomBread;
        }
    }
}