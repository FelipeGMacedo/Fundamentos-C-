﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp
{
    public class TiposNumericos3
    {
        public static void Executa()
        {
            float f1 = 10.5f;
            Console.WriteLine(f1);

            double d1 = 10.1;
            double d2 = 20.2;
            double r = 30.3;
            Console.WriteLine($" {(d1 + d2)} == {r} ");
            Console.WriteLine($" {(d1 + d2) == r}  ");

            decimal dd1 = 10.1m;
            decimal dd2 = 20.2m;
            decimal dd3 = 30.3m;

            Console.WriteLine($" {(dd1 + dd2)} == {dd3} ");
            Console.WriteLine($" {(dd1 + dd2) == dd3}   ");

            Console.WriteLine($" {(dd1 * dd2)} != {dd3} ");
            Console.WriteLine($" {(dd1 * dd2) != dd3}   ");

            Console.WriteLine($" {(dd1 / dd2)} != {dd3} ");
            Console.WriteLine($" {(dd1 / dd2) != dd3}   ");

        }
    }
}
