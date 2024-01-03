using System;
using System.Diagnostics.CodeAnalysis;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1000;
            byte b = (byte)i;

            Console.WriteLine(b);
        }
    }
}
