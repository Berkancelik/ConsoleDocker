﻿using System;

namespace ConsoleDocker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<10000)
            {
                Console.WriteLine("Hello World!" + i);
                System.Threading.Thread.Sleep(1000);
            }

        }
    }
}
