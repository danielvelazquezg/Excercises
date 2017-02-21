using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercises
{
    class Pangrams : IProgram
    {

        public void Run()
        {
            Console.WriteLine("Please enter the sentence you want to evaluate");
            string rawString = Console.ReadLine();
            var characters = rawString.ToLower().Trim().ToArray<char>();

            //Hashtable hash = new Hashtable();
            Dictionary<char, int> alphabet = new Dictionary<char, int>();
            foreach (char c in characters)
            {
                if (!Regex.IsMatch(c.ToString(), "[a-z]"))
                    continue;

                if (!alphabet.Keys.Contains(c))
                {
                    alphabet.Add(c, 1);
                }
                else
                {
                    alphabet[c]++; 
                }
            }

            Console.WriteLine("{0}", alphabet.Count == 26 ? "pangram" : "not pangram");
        }
    }
}
