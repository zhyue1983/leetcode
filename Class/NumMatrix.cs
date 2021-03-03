using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace leetcode.Class
{
    public class NumMatrix
    {
        /*
         给定一个二维矩阵，计算其子矩形范围内元素的总和，该子矩阵的左上角为 (row1, col1) ，右下角为 (row2, col2) 。


        上图子矩阵左上角 (row1, col1) = (2, 1) ，右下角(row2, col2) = (4, 3)，该子矩形内元素的总和为 8。

 

        示例：

        给定 matrix = [
          [3, 0, 1, 4, 2],
          [5, 6, 3, 2, 1],
          [1, 2, 0, 1, 5],
          [4, 1, 0, 1, 7],
          [1, 0, 3, 0, 5]
        ]


        sumRegion(2, 1, 4, 3) -> 8
        sumRegion(1, 1, 2, 2) -> 11
        sumRegion(1, 2, 2, 4) -> 12

        来源：力扣（LeetCode）
         
         
         */
        public NumMatrix(int[][] matrix)
        {
            this.matrix = matrix;
        }
        private int[][] matrix;
        public int SumRegion(int row1, int col1, int row2, int col2)
        {


            int sum = 0;
            for (int i = row1; i <= row2; i++)
            {
                for (int j = col1; j <= col2; j++)
                {
                    sum += matrix[i][j];
                }
            }

            return sum;
        }
    }
}
