using System;

namespace DivideAndConquer
{
    public class MaxSumSubArray
    {
        public static int MaxSum(int[] A, int low, int high)
        {
            if(low == high)
                return A[low];

            int mid = (low + high)/2;

            int maxSumLeftSubArray = MaxSum(A, low, mid);
            int maxSumRightSubArray = MaxSum(A, mid + 1, high);
            int maxSumCrossingSubArray = maxCrossingSubArray(A, low, mid, high);

            return maximum(maxSumLeftSubArray, maxSumRightSubArray, maxSumCrossingSubArray);
        }

        private static int maximum(int a, int b, int c)
        {
            if (a>=b && a>=c)
                return a;
            else if (b>=a && b>=c)
                return b;
            return c;
        }

        private static int maxCrossingSubArray(int[] a, int low, int mid, int high)
        {
            int leftSum = Int32.MinValue;
            int sum = 0;

            for(int i = mid; i>=low; i--)
            {
                sum += a[i];
                if(sum > leftSum)
                    leftSum = sum;
            }

            int rightSum = Int32.MinValue;
            sum = 0;

            for(int i = mid + 1; i <= high; i++)
            {
                sum += a[i];
                if(sum > rightSum)
                    rightSum = sum;
            }

            return leftSum + rightSum;
        }
    }
}