using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macaw
{
    internal class Flobbo
    {
        private string zap;
        public Flobbo(string zap)
        {
            this.zap = zap;
        }
        public static StreamWriter Snobbo()
        {
            return new StreamWriter("macaw.txt");
        }
        public bool Blobbo(bool Already,StreamWriter sw)
        {
            if (Already)
            {
                sw.WriteLine(zap);
                sw.Close();
                return false;
            }
            else
            {
                sw.WriteLine(zap);
                zap = "red orange";
                return true;
            }
        }
        public bool Blobbo(StreamWriter sw)
        {
            sw.WriteLine(zap);
            zap = "green purple";
            return false;
        }
    }
}
