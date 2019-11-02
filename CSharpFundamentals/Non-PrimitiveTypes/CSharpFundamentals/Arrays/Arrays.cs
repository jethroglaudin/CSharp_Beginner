using System;
namespace CSharpFundamentals.Arrays
{
     class Program
    {
        static void Arrays(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "Jack", "John", "Mary" };

            for (var i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

    }
}
