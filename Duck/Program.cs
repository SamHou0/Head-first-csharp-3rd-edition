namespace Duck // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Main(string[] args)
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
            PrintDucks(ducks);

            DuckComparer duckComparer = new DuckComparer();
            duckComparer.SortCriteria = SortCriteria.KindThenSize;
            ducks.Sort(duckComparer);
            PrintDucks(ducks);

            duckComparer.SortCriteria = SortCriteria.SizeThenKind;
            ducks.Sort(duckComparer);
            PrintDucks(ducks);
            Console.ReadKey();
        }
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
                Console.WriteLine(duck);
            //IEnumerator<Duck> enumerator = ducks.GetEnumerator();
            //while (enumerator.MoveNext())
            //    Console.WriteLine(enumerator.Current);
            //IDisposable disposable = enumerator as IDisposable;
            //if (disposable != null) disposable.Dispose();
            //以上注释中的代码与foreach作用相同
            Console.WriteLine("End of ducks!");
        }
    }
}