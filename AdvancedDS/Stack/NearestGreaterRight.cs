using System;
namespace AdvancedDS.Stack
{
    public class NearestGreaterRight
    {
        public NearestGreaterRight()
        {
        }

        #region Greatest number from right
        /* Given an array arr[ ] of size N having elements, 
         * the task is to find the next greater element for each element of the array 
         * in order of their appearance in the array. 
         * Next greater element of an element in the array is the nearest element on the right 
         * which is greater than the current element. If there does not exist next greater of current element, 
         * then next greater element for current element is -1. 
         * For example, next greater of the last element is always -1.
        Example 1:

        Input: N = 4, arr[] = [1 3 2 4]
        Output: 3 4 4 -1
         */

        public static List<int> NGR(int n, int[] arr)
        {
            //Your code here
            Stack<int> sk = new Stack<int>();
            List<int> result = new List<int>();
            int i = n - 1;

            while (i >= 0)
            {
                if (sk.Count == 0)
                {
                    result.Insert(0, -1);
                    sk.Push(arr[i--]);
                }
                else if (sk.Peek() > arr[i])
                {
                    result.Insert(0, sk.Peek());
                    sk.Push(arr[i--]);
                }
                else sk.Pop();
            }
            return result;
        }
        #endregion
    }
}

