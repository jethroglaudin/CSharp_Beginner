using CSharpFundamentals.Math;
using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var jethro = new Person();
            jethro.FirstName = "Jethro";
            jethro.LastName = "Glaudin";
            jethro.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
