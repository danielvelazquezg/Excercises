using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class SparesArrays : IProgram
    {
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, int> strings = new Dictionary<string, int>();
            for(int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                if (!strings.Keys.Contains(word))
                    strings.Add(word, 1);
                else
                    strings[word]++;
            }

            int q = Convert.ToInt32(Console.ReadLine());
            string[] queries = new string[q];
            for(int i = 0; i < q; i++)
            {
                queries[i] = Console.ReadLine();
            }

            for(int i = 0; i < q; i++)
            {
                if(!strings.Keys.Contains(queries[i]))
                    Console.WriteLine("0");
                else
                    Console.WriteLine(strings[queries[i]]);
            }
        }
    }
}
