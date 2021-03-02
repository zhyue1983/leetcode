using leetcode.Class;
using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(TwoSum.GetTwoSum(new int[] { 3, 2, 4, 3 }, 6).ToJson());
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine(ReverseInteger.Reverse(-123));
            Console.WriteLine("-------------------------------------------------------------------");
        }
    }
}
