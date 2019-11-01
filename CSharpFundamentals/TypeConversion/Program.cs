using System;

namespace TypeConversion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //byte b = 1; // 1 bite
            //int i = b; // 4 bytes;
            //Console.WriteLine(i);

            //int i = 1;
            //// cast interger to byte
            //byte b = (byte)i;
            //Console.WriteLine(b);

            var number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);
        }
    }
}
