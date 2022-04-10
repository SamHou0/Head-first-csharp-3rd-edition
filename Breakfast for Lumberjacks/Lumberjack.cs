using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakfast_for_Lumberjacks
{
    internal class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;
        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }
        public int FlapjackCount { get { return meal.Count; } }
        public void TakeFlapjacks(Flapjack food, int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                meal.Push(food);
            }
        }
        public void EatFlapjacks()
        {
            //注意：由于使用了.net 6.0，Console.WriteLine()在输出窗口似乎不再可用，
            //可以将项目调整为控制台应用，这样会显示控制台。
            Console.WriteLine(Name + "'s eating flapjacks");
            for (int i = 0; i < meal.Count; i++)
            {
                Console.WriteLine(name + " ate a " + meal.Pop().ToString().ToLower() + " flapjack");
            }
        }
    }
}
