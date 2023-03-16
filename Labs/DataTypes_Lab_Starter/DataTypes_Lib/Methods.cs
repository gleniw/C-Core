using System;
using System.Security.Cryptography.X509Certificates;

namespace DataTypes_Lib
{
    public static class Methods
    {
        // Implement the method `Methods.Factorial` so that it returns the product of all numbers from 1 to `n` inclusive.
        // write a method to return the product of all numbers from 1 to n inclusive
        public static int Factorial(int n)
        {
            int sum = 0;

            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static float Mult(float num1, float num2)
        {
            return  num1 * num2;
        }
    }
}