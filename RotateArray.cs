using System;

namespace TestApplication
{
    internal static class Program
    {
        public static void Main()
        {
            int[,] array = {{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}, {13, 14, 15, 16}};
            var mx = new Matrix();
            Matrix.Displaymatrix(array);
 
            Matrix.Degree90Matrix(array);
        }
    }

    internal class Matrix
    {
        public static void Displaymatrix(int[,] array)
        {
            var m = array.GetLength(0);
            var n = array.GetLength(1);
            
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        public static void Degree90Matrix(int[,] array)
        {
            var m = array.GetLength(0);
            var n = array.GetLength(1);
            
            int j=0, p=0, q=0;
            var i = m - 1;
            var rotateArr = new int[m,n];
            for (var k = 0; k < m; k++)
            {
                while (i >=0)
                {
                    rotateArr[p, q] = array[i, j];
                    q++;
                    i--;
                }
                j++;
                i = m - 1;
                q = 0;
                p++;
            }
                Displaymatrix(rotateArr);
        }
    }
}
