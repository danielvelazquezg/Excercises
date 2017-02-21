using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class ArrayList : IProgram
    {
        public void Run()
        {
            Console.WriteLine("Choose the option");
            Console.WriteLine("1. Unique characters");
            Console.WriteLine("2. Reverse C-Style string");
            Console.WriteLine("3. Remove duplicates");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    UniqueCharacters();
                    break;
                case 2:
                    ReverseCStyleString();
                    break;
                case 3:
                    RemoveDuplicates();
                    break;
                case 4:
                    IdentifyAnagrams();
                    break;
                case 5:
                    Replace();
                    break;
                case 6:
                    break;
                case 7:
                    break;
            }
        }

        private void Replace()
        {
            Console.Write("Enter the string to replace the spaces: ");
            string s = Console.ReadLine();
            char[] chars = new char[1000];
            chars = s.ToCharArray();
            int length = chars.Length;
            int spaceCounter = 0;
            for (int i = 0; i < length - 1; i++)
            {
                if (chars[i] == ' ')
                    spaceCounter++;
            }

            int newLength = length + (spaceCounter * 2);
            for (int i = length; i <= 0; i--) 
            {
 
            }
        }

        private void IdentifyAnagrams()
        {
            Console.Write("Enter first string: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            string s2 = Console.ReadLine();

            char[] chars1 = s1.Trim().ToCharArray();
            Array.Sort(chars1);
            char[] chars2 = s2.Replace(" ","").ToCharArray();
            Array.Sort(chars2);
            if(chars1.Length != chars2.Length)
                Console.WriteLine("Not anagrams");
            for (int i = 0, j = chars1.Length - 1; i < chars1.Length; i++,j--)
            {
                if(chars1[i] != chars2[i])
                    Console.WriteLine("Not anagrams");
            }
            
            Console.WriteLine("They are anagrams");
        }

        private void RemoveDuplicates()
        {
            Console.Write("Enter the string: ");
            char[] chars = Console.ReadLine().ToCharArray();

            StringBuilder sb = new StringBuilder();
            foreach (char c in chars)
            {
                if (Array.IndexOf(sb.ToString().ToCharArray(), c) == -1)
                    sb.Append(c.ToString());
            }

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }

        private void ReverseCStyleString()
        {
            Console.Write("Enter the string you want to reverse: ");
            string s = Console.ReadLine();

            char[] chars = s.ToCharArray();
            int stringLength = chars.Length;

            char[] revertedChars = new char[stringLength + 1];

            int j = 0; 
            for (int i = stringLength; i > 0; i--)
            {
                revertedChars[i] = chars[j];
                j++;
            }
        }

        private void UniqueCharacters()
        {
            Console.Write("Enter the string you want to evaluate: ");
            string s = Console.ReadLine();

            Hashtable hash = new Hashtable();
            foreach (char c in s.ToCharArray())
            {
                if (hash.Contains(c))
                {
                    Console.WriteLine("String has duplicated characters");
                    return;
                }
                else
                    hash.Add(c, c);
            }

            Console.WriteLine("String doesn't have duplicated characters");
            Console.ReadLine();
        }
    }
}
