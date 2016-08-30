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

        private void Bet()
        {
            Random randomBet = new Random();
            var EvenOdd = randomBet.Next(1, 2);

            if (EvenOdd == 1)
            {
                Croupier croupier = new Croupier();
                croupier.BetOdd();                
            }
            else
            {
                Croupier croupier = new Croupier();
                croupier.BetEven();
            }
        }

        public void ReceiveCash()
        {

        }
    }
}
