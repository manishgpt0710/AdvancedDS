using System;
namespace AdvancedDS.Stack
{
    public class MaxAreaRectangle
    {
        public MaxAreaRectangle()
        {
        }

        /* Given a binary matrix M of size n X m. 
         * Find the maximum area of a rectangle formed only of 1s in the given matrix.

            Example 1:

            Input:
            n = 4, m = 4
            M[][] = {{0 1 1 0},
                     {1 1 1 1},
                     {1 1 1 1},
                     {1 1 0 0}}
            Output: 8
            Explanation: For the above test case the
            matrix will look like
            0 1 1 0
            1 1 1 1
            1 1 1 1
            1 1 0 0
            the max size rectangle is 
            1 1 1 1
            1 1 1 1
            and area is 4 *2 = 8.
         */

        public int MaxArea(int[][] M, int n, int m)
        {
            //Your code here
            int maxArea = 0;
            int[] height = new int[m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (M[i][j] == 0)
                        height[j] = 0;
                    else
                        height[j] += M[i][j];
                }
                maxArea = Math.Max(maxArea, MaxAreaHistogram(height, m));
            }
            return maxArea;
        }

        private int MaxAreaHistogram(int[] arr, int n)
        {
            int[] right = NearestSmallerRightIndex(arr);
            int[] left = NearestSmallerLeftIndex(arr);
            int mah = 0;

            for (int ii = 0; ii < n; ii++)
            {
                mah = Math.Max(mah, arr[ii] * (right[ii] - left[ii] - 1));
            }
            return mah;
        }

        private static int[] NearestSmallerLeftIndex(int[] arr)
        {
            Stack<int> sk = new Stack<int>();
            int[] left = new int[arr.Length];
            int i = 0;

            while (i < arr.Length)
            {
                if (sk.Count == 0)
                {
                    left[i] = -1;
                    sk.Push(i++);
                }
                else if (arr[sk.Peek()] < arr[i])
                {
                    left[i] = sk.Peek();
                    sk.Push(i++);
                }
                else
                {
                    sk.Pop();
                }
            }
            return left;
        }

        private static int[] NearestSmallerRightIndex(int[] arr)
        {
            Stack<int> sk = new Stack<int>();
            int[] right = new int[arr.Length];
            int i = arr.Length - 1;

            while (i >= 0)
            {
                if (sk.Count == 0)
                {
                    right[i] = arr.Length;
                    sk.Push(i--);
                }
                else if (arr[sk.Peek()] < arr[i])
                {
                    right[i] = sk.Peek();
                    sk.Push(i--);
                }
                else
                {
                    sk.Pop();
                }
            }
            return right;
        }
    }
}

