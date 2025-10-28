﻿using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList =
        {
        "a - Add",
        "s - Subtract",
        "m - Multiply",
        "dr - Divide Remainder",
        "ex - Exit"
    };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }

        public static void DivideRemainder(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed!");
                return;
            }

            Console.WriteLine($"{a} % {b} = {a % b}");
        }
    }

}
