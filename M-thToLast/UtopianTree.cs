using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class UtopianTree : IProgram
    {

        public void Run()
        {
            Console.Write("Enter the number of test cases: ");
            int t = Convert.ToInt32(Console.ReadLine());
            int[] cycles = new int[t];

            Console.WriteLine("Enter the number of cycles {0} times: ", t);
            for(int a0 = 0; a0 < t; a0++){
                cycles[a0] = Convert.ToInt32(Console.ReadLine());
            }
            for (int a0 = 0; a0 < t; a0++) {
                int h = 1;

                if (cycles[a0] == 0)
                    Console.WriteLine("1");
                else if (cycles[a0] == 1)
                    Console.WriteLine("2");
                else
                {
                    int springs = cycles[a0] % 2 == 0 ? cycles[a0] / 2 : (cycles[a0] / 2) + 1;
                    bool endsInSummer = cycles[a0] % 2 == 0;

                    for (int c = 0; c < springs; c++)
                    {
                        h *= 2;
                        if (endsInSummer || c < springs - 1)
                            h++;
                    }

                    Console.WriteLine(h);
                }
            }
        }
    }
}
