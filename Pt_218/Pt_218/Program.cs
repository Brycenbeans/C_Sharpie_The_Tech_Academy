﻿using System;

namespace Pt_218
{
    class Program
    {
        static void Main(string[] args)
        {
            Math Math = new Math();
            Console.WriteLine("Pick a number to add 5 to");
            int One = Convert.ToInt32(Console.ReadLine());
            int Result = Math.MathA(One);
            Console.WriteLine(Result);
            Console.ReadLine();

            Console.WriteLine("Pick a decimal to multiply by 5");
            decimal Two = Convert.ToDecimal(Console.ReadLine());
            int Result2 = (int)Math.MathA(Two);
            Console.WriteLine(Result2);
            Console.ReadLine();

            Console.WriteLine("Type a string (number) to add 7 to");
            string Three = Console.ReadLine();
            int Result3 = Math.MathA(Three);
            Console.WriteLine(Result3);
            Console.ReadLine();
        }
    }
}
