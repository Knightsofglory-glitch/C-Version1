using System;
using System.Diagnostics.CodeAnalysis;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "1";
            int i = Convert.ToInt32(s);

            Console.WriteLine(i);
            Console.WriteLine(s);
        }
    }
}
