using System;

namespace DivideAndConquer
{
    class SearchInANearlySortedArray
    {
        public static int Search(int[] A, int x)
        {
            int left = 0; 
            int right = A.Length - 1;

            while(left <= right)
            {
                int mid = (left + right)/2; 
                
                if(x == A[mid])
                    return mid;
                else if(mid + 1 <= right && x == A[mid + 1])
                    return mid + 1;
                else if(mid - 1 <= left && x == A[mid - 1])
                    return mid - 1;
                else if(x < A[mid])
                    right = mid - 2;
                else
                    left = mid + 2;

            }
            return -1;
        }
    }
}