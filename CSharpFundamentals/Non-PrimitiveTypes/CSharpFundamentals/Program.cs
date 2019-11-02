using CSharpFundamentals.Math;
using System;

namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var jethro = new Person();
            //jethro.FirstName = "Jethro";
            //jethro.LastName = "Glaudin";
            //jethro.Introduce();

            //Calculator calculator = new Calculator();
            //var result = calculator.Add(1, 2);
            //Console.WriteLine(result);


            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            // parse the string to different type.
            // parse string into an Enum
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
