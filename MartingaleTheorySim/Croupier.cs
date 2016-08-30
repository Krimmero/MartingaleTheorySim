using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MartingaleTheorySim
{
    class Croupier
    {
        private bool betOnEven;
        private bool betOnOdd;
        private int rouletteNumber;

        private int SpinRoulette()
        {
            Roulette roulette = new Roulette();
            rouletteNumber = roulette.Spin();
            return rouletteNumber;
        }

        public int GetRouletteNumber()
        {
            rouletteNumber = SpinRoulette();
            return rouletteNumber;
        }

        public void BetEven()
        {
            rouletteNumber = GetRouletteNumber();

            if (rouletteNumber % 2 == 0)
            {
                
                
            }
            else
            {
                
            }

        }

        public void BetOdd()
        {

        }
    }
}
