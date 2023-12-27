using System;
namespace AdvancedDS.Stack
{
    public class NearestSmallerLeft
    {
        public NearestSmallerLeft()
        {
        }

        #region Smallest number on left
        /* Given an array a of integers of length n, 
         * find the nearest smaller number for every element such that the smaller element is on left side.
         * If no small element present on the left print -1.
        Example 1:

        Input: n = 3
        a = {1, 6, 2}
        Output: -1 1 1
        Explaination: There is no number at the 
        left of 1. Smaller number than 6 and 2 is 1.
         */

        public static List<int> NSL(int n, int[] a)
        {
            //Your code here
            Stack<int> sk = new Stack<int>();
            List<int> result = new List<int>();
            int i = 0;
            while (i < n)
            {
                if (sk.Count == 0)
                {
                    sk.Push(a[i++]);
                    result.Add(-1);
                }
                else if (sk.Count > 0 && sk.Peek() < a[i])
                {
                    result.Add(sk.Peek());
                    sk.Push(a[i++]);
                }
                else
                {
                    sk.Pop();
                }
            }
            return result;
        }
        #endregion
    }
}

