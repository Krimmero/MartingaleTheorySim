﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MartingaleTheorySim
{
    class Program
    {
        static void Main(string[] args)
        {
            Croupier croupier = new Croupier();
            croupier.GetRouletteNumber();
            Console.ReadLine();
        }
    }
}
