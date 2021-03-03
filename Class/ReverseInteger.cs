using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Class
{
    /*
     给你一个 32 位的有符号整数 x ，返回 x 中每位上的数字反转后的结果。

    如果反转后整数超过 32 位的有符号整数的范围 [−231,  231 − 1] ，就返回 0。

    假设环境不允许存储 64 位整数（有符号或无符号）。
 

    示例 1：

    输入：x = 123
    输出：321
    示例 2：

    输入：x = -123
    输出：-321
    示例 3：

    输入：x = 120
    输出：21
    示例 4：

    输入：x = 0
    输出：0

    来源：力扣（LeetCode）
     */
    public class ReverseInteger
    {
        public static int Reverse(int x)
        {

            string resReverse = string.Join(string.Empty, x.ToString().Reverse());
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
