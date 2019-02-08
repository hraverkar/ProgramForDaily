using System;

namespace ConsoleApplication11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] {10, 2, 4, 8, 6};

            var a = TwoSum(arr, 12);

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] );
            }
            
        }


        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {

                        if (nums[j] == target - nums[i])
                        {
                            return new int[] {i, j};
                        }
                    }
                }
            }
            catch (Exception aE)

            {
                Console.WriteLine(aE);
            }

            return null;
        }
    }
}
