using System;

namespace Fibonacci
{
    public class FibonacciCalculator
    {
        public int GetValue(int n)
        {
            if (n==0)
            {
                return 0;
            }
            else if (n==1)
            {
                return 1;
            }
            else
            {
                return GetValue(n-1) + GetValue(n-2);
            }
        }

        public int GetDepth(int n)
        {
            if (n==0);
            {
                return 0;
            }
            else 
            {
                return n+1;
            }
        }
    }
}
