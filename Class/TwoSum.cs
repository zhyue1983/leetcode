using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace leetcode.Class
{
    public class TwoSum
    {
        /*
        给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 的那 两个 整数，并返回它们的数组下标。

        你可以假设每种输入只会对应一个答案。但是，数组中同一个元素不能使用两遍。

        你可以按任意顺序返回答案。

 

        示例 1：

        输入：nums = [2,7,11,15], target = 9
        输出：[0,1]
        解释：因为 nums[0] + nums[1] == 9 ，返回 [0, 1] 。
        示例 2：

        输入：nums = [3,2,4], target = 6
        输出：[1,2]
        示例 3：

        输入：nums = [3,3], target = 6
        输出：[0,1]
 

        提示：

        2 <= nums.length <= 103
        -109 <= nums[i] <= 109
        -109 <= target <= 109
        只会存在一个有效答案

        来源：力扣（LeetCode）
         * */
        public static int[] GetTwoSum(int[] nums, int target)
        {
            //核心在于不能用 A+B=target (复杂度太高) 用target-A=B 去判断B是否存在

            for (int i = 0; i < nums.Length; i++)
            {
                int numValue = target - nums[i];

                if (nums.Contains(numValue))
                {
                    List<int> arr = new List<int>(nums);
                    int index1 = arr.LastIndexOf(numValue);
                    if (index1 == i)
                    {
                        continue;
                    }
                    return new int[2] { i, index1 };
                }

            }
            return null;
        }
    }

}
