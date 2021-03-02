using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Class
{
    /*
     * Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1], then return 0.
     * Assume the environment does not allow you to store 64-bit integers (signed or unsigned). 
     *
     *Example 1:

        Input: x = 123
        Output: 321
     *
     *Example 2:

        Input: x = -123
        Output: -321
     *
     *Example 3:

        Input: x = 120
        Output: 21
     *
     *Example 4:

        Input: x = 0
        Output: 0
     *
     *
     */
    public class ReverseInteger
    {
        public static int Reverse(int x)
        {

            string resReverse = string.Join("", x.ToString().Reverse());
            if (x < 0)
            {
                resReverse = $"-{resReverse.Substring(0, resReverse.Length - 1)}";
            }
            try
            {
                return Convert.ToInt32(resReverse);
            }
            catch (Exception e)
            {
                if (e is OverflowException)
                {
                    return 0;
                }
                throw;
            }



        }
    }
}
