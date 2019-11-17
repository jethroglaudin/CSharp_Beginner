using System;
namespace Conditionals_Loops
{
    public class Iterations
    {

        public void Loop(int num1)
        {

            for (var i = 0; i <= num1 ; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = num1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
