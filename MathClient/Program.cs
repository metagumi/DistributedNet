using System;

namespace MathClient
{
    class MathClient
    {
        // Initial commit
        public static void Main(string[] args)
        {
            Console.WriteLine(" 5 + 3 = {0}", 
                              MathLibrary.SimpleMath.Add(5, 3));

            Console.WriteLine(" 5 - 3 = {0}", 
                              MathLibrary.SimpleMath.Subtract(5, 3));
            
            Console.WriteLine(" 5 * 3 = {0}",
                  MathLibrary.SimpleMath.Multiply(5, 3));

            Console.WriteLine(" 5 / 3 = {0}",
                  MathLibrary.SimpleMath.Divide(5, 3));


            Console.ReadLine();
        }
    }
}
