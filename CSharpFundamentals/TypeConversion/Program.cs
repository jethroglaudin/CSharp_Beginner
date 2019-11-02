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
            try
            {
                //var number = "1234";
                //byte b = Convert.ToByte(number);
                //Console.WriteLine(b);

                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }

            catch(Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            //var number = "1234";
            //int i = Convert.ToInt32(number);
            //Console.WriteLine(i);

            
        }
    }
}
