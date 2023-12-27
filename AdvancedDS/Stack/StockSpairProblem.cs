using System;
namespace AdvancedDS.Stack
{
    public class StockSpairProblem
    {
        public StockSpairProblem()
        {
        }

        /* The stock span problem is a financial problem 
         * where we have a series of n daily price quotes for a stock 
         * and we need to calculate the span of stocks price for all n days. 
         * The span Si of the stocks price on a given day i is defined as 
         * the maximum number of consecutive days just before the given day, 
         * for which the price of the stock on the given day is 
         * less than or equal to its price on the current day. 
         * For example, if an array of 7 days prices is given as {100, 80, 60, 70, 60, 75, 85}, 
         * then the span values for corresponding 7 days are {1, 1, 1, 2, 1, 4, 6}.
         */
        public static string calculateSpan(int[] price, int n)
        {
            //Your code here
            Stack<int> sk = new Stack<int>();
            List<int> spans = new List<int>();
            int i = 0;

            // Calculate the index of Nearest Greater left
            while (i < n)
            {
                if (sk.Count == 0)
                {
                    spans.Add(i + 1);
                    sk.Push(i++);
                }
                else if (price[sk.Peek()] > price[i])
                {
                    spans.Add(i - sk.Peek());
                    sk.Push(i++);
                }
                else
                {
                    sk.Pop();
                }
            }

            return String.Join(" ", spans);
        }
    }
}

