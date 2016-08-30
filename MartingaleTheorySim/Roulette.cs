using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MartingaleTheorySim
{
    class Roulette
    {
        private Random random;

        public int Spin()
        {
            random = new Random();
            
            return random.Next(1, 36);
        }
    }
}
