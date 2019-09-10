using System;

class Program
{
  int SubArray(int[] arr, int n, int sum)
  {
    int curr_sum = arr[0],
             start = 0, i;
    for (i = 1; i <= n; i++)
    {
      while (curr_sum > sum &&
             start < i - 1)
      {
        curr_sum -= arr[start];
        start++;
      }
      if (curr_sum == sum)
      {
        int p = i - 1;
        Console.WriteLine( start +" "+ p);
        return 1;
      }

      // Add this element to curr_sum 
      if (i < n)
        curr_sum += arr[i];

    }
    Console.WriteLine("No subarray found");
    return 0;
  }
  public static void Main()
  {
    Program arraysum = new Program();
    int[] arr = new int[] {15, 2, 4, 8,
                              9, 5, 10, 23};
    int n = arr.Length;
    int sum = 23;
    arraysum.SubArray(arr, n, sum);
  }
}
