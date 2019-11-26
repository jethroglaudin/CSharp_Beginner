using System;
namespace Loops
{
    public class Program
    {
        public void Random(int num2)
        {
            var random = new Random();
            for (var i = num2; i < 10; i++)
                Console.WriteLine(random.Next());
            
            
        }
    }
}
