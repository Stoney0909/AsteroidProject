using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_ONe.Content
{
    class Rnd
    {
        Random rnds = new Random();

        public Rnd()
        {

        }

        int rnd(int min, int max)
        {
            return rnds.Next(min, max);
        }

        public int Range(int min, int max)
        {
            return rnds.Next(min, max);
        }
    }
}
