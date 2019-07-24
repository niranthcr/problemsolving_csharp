using System;

namespace DivideAndConquer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3, -1, -1, 10, -3, -2, 4};
            Console.WriteLine($"The maximum sum of the given array is {MaxSumSubArray.MaxSum(A, 0, A.Length - 1)}");

            ////////////////Search in nearly Sorted Array/////////////////////////////////////
            // int[] A = { 2,1,3,5,6,7,6,8,9 };
            // int target = 3;
            // int index = SearchInANearlySortedArray.Search(A, target);

            // Console.WriteLine($"The target {3} is at the index {index}");

            /////GETFLOORANDCEIL////////
            // int[] A ={1,4,6,8,9};
            // for(int i=0;i<=10;i++)
            // {
            //     Console.Write($"Number {i} ->");
            //     Console.WriteLine($"Ceiling is { GetCeilOrFloor.SubGetCeilOrFloor(A, i, true) } Floor is { GetCeilOrFloor.SubGetCeilOrFloor(A, i, false) }");
            // }
        }

        
    }

    
}
