using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macaw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flobbo f = new("blue yellow");
            StreamWriter sw = Flobbo.Snobbo();
            f.Blobbo(f.Blobbo(f.Blobbo(sw), sw), sw);
        }
    }
}
