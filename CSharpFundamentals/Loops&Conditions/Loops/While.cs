using System;
namespace Conditionals_Loops
{
    public class While
    {

        public void Loop()
        {

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
            }

        }
    }
}
