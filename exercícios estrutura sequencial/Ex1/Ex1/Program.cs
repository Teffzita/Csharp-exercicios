﻿using System;

namespace Ex1
{
    internal class Program {
        static void Main(string[] args) {
            int A, B, Soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            Soma = A + B;

            Console.WriteLine("Soma:" + Soma);
        }
    }
}