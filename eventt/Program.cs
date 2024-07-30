using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            done done = new done();
            fordone fordone = new fordone();

            done.abc += fordone.afterdone;

            done.asd();

        }
    }
}
