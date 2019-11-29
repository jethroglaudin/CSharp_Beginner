using System;
using System.Collections.Generic;

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

            // Clear()
            Array.Clear(numbers, 0, 2);


            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy");
            foreach(var n in another)
                Console.WriteLine(n);

            // Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // List
            var numbers_list = new List<int>() { 1, 2, 3, 4 };
            numbers_list.Add(1);
            numbers_list.AddRange(new int[3] { 5, 6, 7 });

            foreach(var number in numbers_list)
                Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers_list.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + numbers_list.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers_list.Count);

            for (var i = 0; i < numbers_list.Count; i++)
            {
                if (numbers_list[i] == 1)
                    numbers_list.Remove(numbers_list[i]);         
            }        
            foreach (var number in numbers_list)
                Console.WriteLine(number);

            numbers_list.Clear();
            Console.WriteLine("Count: " + numbers_list.Count);
        }
    }
}
