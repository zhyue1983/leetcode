using leetcode.Class;
using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----------------------------GetTwoSum--------------------------------------");
            Console.WriteLine(TwoSum.GetTwoSum(new int[] { 3, 2, 4, 3 }, 6).ToJson());

            Console.WriteLine("-----------------------------ReverseInteger--------------------------------------");
            Console.WriteLine(ReverseInteger.Reverse(-123));

            Console.WriteLine("-----------------------------NumMatrix--------------------------------------");
            int[][] num = new int[][] { new int[] { 3, 0, 1, 4, 2 }, new int[] { 5, 6, 3, 2, 1 }, new int[] { 1, 2, 0, 1, 5 }, new int[] { 4, 1, 0, 1, 7 }, new int[] { 1, 0, 3, 0, 5 } };
            Console.WriteLine(new NumMatrix(num).SumRegion(2, 1, 4, 3));

            Console.WriteLine("-----------------------------FindMedianSorted--------------------------------------");
            Console.WriteLine(FindMedianSorted.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2, 2 }));
        }
    }
}
