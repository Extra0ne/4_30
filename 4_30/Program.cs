﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            do
            {
                Console.Write("Введите любое число :");
                num = Convert.ToInt32(Console.ReadLine());

            } while (num != 1);
        }
    }
}
