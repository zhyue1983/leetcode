﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leetcode.Class
{
    public class FindMedianSorted
    {
        /*
         * 给定两个大小分别为 m 和 n 的正序（从小到大）数组 nums1 和 nums2。请你找出并返回这两个正序数组的 中位数 。

 

            示例 1：

            输入：nums1 = [1,3], nums2 = [2]
            输出：2.00000
            解释：合并数组 = [1,2,3] ，中位数 2
            示例 2：

            输入：nums1 = [1,2], nums2 = [3,4]
            输出：2.50000
            解释：合并数组 = [1,2,3,4] ，中位数 (2 + 3) / 2 = 2.5
            示例 3：

            输入：nums1 = [0,0], nums2 = [0,0]
            输出：0.00000
            示例 4：

            输入：nums1 = [], nums2 = [1]
            输出：1.00000
            示例 5：

            输入：nums1 = [2], nums2 = []
            输出：2.00000

            来源：力扣（LeetCode）
         * 
         * 
         */



        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var nums = nums1.Concat(nums2);
            var numsOrderBY = nums.OrderBy(a => a).ToArray();
            int index = (nums.Count()) / 2;
            if (nums.Count() % 2 == 0)
            {

                return (numsOrderBY[index] + numsOrderBY[index - 1]) / 2.0;
            }
            else
            {
                return numsOrderBY[index];
            }
        }
        public static double FindMedianSortedArrays2(int[] nums1, int[] nums2)
        {
            int count1 = nums1.Length;
            int count2 = nums2.Length;
            int[] nums = new int[count1 + count2];

            return 1d;
        }
    }
}
