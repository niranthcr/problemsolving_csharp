using System;

namespace DivideAndConquer
{
    class GetCeilOrFloor
    {
        public static int SubGetCeilOrFloor(int[] A, int x, bool isCeil)
        {
            int left = 0;
            int right = A.Length - 1;
            int result = -1;

            if(isCeil)
            {
                while(left <= right)
                {
                    int mid = (left + right)/2;

                    if(A[mid] == x)
                        return A[mid];
                    else if(x < A[mid])
                    {
                        result = A[mid];
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }    
            else 
            {
                while(left <= right)
                {
                    int mid = (left + right)/2;

                    if(A[mid] == x)
                        return A[mid];
                    else if(x < A[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        result = A[mid];
                        left = mid + 1;
                    }
                }
            }
            return result;
        }
    }
}