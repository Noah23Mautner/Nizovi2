﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizovi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niz1 = { 1, 2, 3, 4, 5 };
            int[] niz2 = { 1, 10, 5, 4, 5 };

            int brojIstihClanova = 0;

            for (int i = 0; i < niz1.Length; i++)
            {
                if (niz1[i] == niz2[i])
                {
                    brojIstihClanova++;
                }
            }

            Console.WriteLine("Broj članova koji se nalaze na istom indeksu i imaju istu vrijednost: " + brojIstihClanova);
            Console.ReadKey();
        }

        
    }
    }

