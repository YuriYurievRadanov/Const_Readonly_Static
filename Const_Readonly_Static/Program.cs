using System;

namespace Const_Readonly_Static
{
    internal class Program
    {
        public class ConstReadOnly
        {
            //The const variable must be valued as soon as it is defined.
            public const double Pi = 3.14159;

            public readonly int X = 3;
            public readonly int Y;

            public ConstReadOnly(int value)
            {
                //readonly variables can be assigned within the constructor method.
                Y = value;
            }
        }

        public static void Main()
        {
            //PI = 3.5;  ERROR

            var obj = new ConstReadOnly(77);

            Console.WriteLine(obj.Y);
            Console.WriteLine(obj.X);

            /*  Since a value that is const is also static, we reach it with the class name.  */

            Console.WriteLine(ConstReadOnly.Pi);
        }

        public class Fuzzy
        {
            static readonly int x = 1;  // Noncompliant
            static readonly int y = x + 4; // Noncompliant
            static readonly string s = "Bar";  // Noncompliant
        }

        public class Buzzy
        {
            public const int X = 1;
            private const int Y = X + 4;
            const string S = "Bar";

            //static const string D = "Bar"; //The constant 'd' cannot be marked static
        }

        private class Math
        {
            public static int Total(int x, int y)
            {
                var z = x + y;
                return z;
            }

        }

        class Result
        {
            static void MainMethod(string[] args)
            {
                int returnValue = Math.Total(3, 5);
                Console.WriteLine(returnValue);
            }
        }
    }
}
