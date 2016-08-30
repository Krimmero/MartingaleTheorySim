using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartingaleTheorySim
{
    class PlayGame
    {
        public void StartGame()
        {
            

            Gambler gambler = new Gambler();
            Croupier croupier = new Croupier();
            Roulette roulette = new Roulette();

            gambler.Cash = 30000;
        }
    }
}
