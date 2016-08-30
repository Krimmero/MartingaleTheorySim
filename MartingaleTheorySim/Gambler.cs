using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartingaleTheorySim
{
    class Gambler
    {
        public int Cash { get; set; }

        public Gambler(int cash)
        {
            Cash = cash;
        }
        public void Bet()
        {
            
            Random randomBet = new Random();
            var EvenOdd = randomBet.Next(1, 2);

            if (EvenOdd == 1)
            {
                   
            }
            else
            {
                
            }
        }

        public void ReceiveCash()
        {

        }
    }
}
