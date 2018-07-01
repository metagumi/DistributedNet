using System;

namespace MathClient
{
    class MathClient
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" 5 + 3 = {0}", 
                              MathLibrary.SimpleMath.Add(5, 3));

            Console.WriteLine(" 5 - 3 = {0}", 
                              MathLibrary.SimpleMath.Subtract(5, 3));

            Console.ReadLine();
        }
    }
}
