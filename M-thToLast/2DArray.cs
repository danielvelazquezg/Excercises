using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class _2DArray : IProgram
    {
        public void Run()
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            List<int> sums = new List<int>();
            for (int h = 0; h < 4; h++)
            {
                for (int w = 0; w < 4; w++)
                {
                    sums.Add(arr[w][h] +
                             arr[w][h + 1] +
                             arr[w][h + 2] +
                             arr[w+1][h+1] +
                             arr[w + 2][h] +
                             arr[w + 2][h + 1] +
                             arr[w+2][h+2]);
                }
            }
                
            Console.WriteLine(sums.OrderByDescending(s => s).First());
        }
    }
}
