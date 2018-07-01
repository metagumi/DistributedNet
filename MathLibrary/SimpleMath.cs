using System;
namespace MathLibrary
{
    //Initial commit
    public class SimpleMath
    {
        public SimpleMath()
        {
        }

        public static int Add(int n1, int n2) {
            return n1 + n2;
        }

        public static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Multiply(int n1, int n2) {
            return n1 * n2;
        }

        public static int Divide(int n1 , int n2) {
            if ( n2 == 0 ) {
                return 0;
            } else {
                return n1 / n2;
            }
        }

    }
}
