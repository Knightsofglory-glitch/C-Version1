using System;
using System.Diagnostics.CodeAnalysis;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("the number couldnt be converted to a bite");
            }
           
        }
    }
}
