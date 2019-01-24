using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            PrintArray(arr,9);
            ReverseArray(arr,0,8);
            
            PrintArray(arr, 9);
            Console.ReadKey();
        }

        private static void ReverseArray(int[] arr,int start, int end)
        {
            int temp;
            while(start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        private static void PrintArray(int[] arr, int v)
        {
           for(int i=0; i<v; i++)
            {
               Console.Write(arr[i] + " "); 
            }
            Console.WriteLine(" \n");
        }
    }
}
