using System;

namespace Arrays_Lists
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 5, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);
        }
    }
}
