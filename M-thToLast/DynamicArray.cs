using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class DynamicArray : IProgram
    {
        public void Run()
        {
            string input = Console.ReadLine();
            int N = Convert.ToInt32(input.Split(' ')[0]);
            int numberOfSeq = Convert.ToInt32(input.Split(' ')[1]); 
            int lastAns = 0;
            List<int> S0 = new List<int>();
            List<int> S1 = new List<int>();

            int[][] seqList = new int[N][];


            for (int i = 0; i < numberOfSeq; i++)
            {
                seqList[i] = Console.ReadLine().Split(' ').Select(p => Convert.ToInt32(p)).ToArray();
            }

            for (int i = 0; i < numberOfSeq; i++)
            {
                int seq = (seqList[i][1] ^ lastAns) % N;

                if (seqList[i][0] == 1)
                {
                    if (seq == 0)
                        S0.Add(seqList[i][2]);
                    else
                        S1.Add(seqList[i][2]);
                }
                else 
                {
                    lastAns = (seq == 0) ? S0[S0.Count - 1] : S1[S1.Count - 1];
                    Console.WriteLine(lastAns);
                }
            }
        }
    }
}
