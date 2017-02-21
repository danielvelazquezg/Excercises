using System;
using System.Collections.Generic;
using System.IO;

namespace Exercises
{
    public class MthToLast : IProgram
    {
        public MthToLast()
        {
        }

        public void Run()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            var index = Console.ReadLine();
            var listString = Console.ReadLine();
            var linkedList = FillList(listString);

            Console.Write(FindElementByIndex(linkedList, Convert.ToInt32(index)));

            Console.ReadKey();
        }

        public static LinkedList<int> FillList(string listString)
        {
            var list = new LinkedList<int>();
            foreach (string valueNode in listString.Split(' '))
            {
                if (list.Count == 0)
                {
                    
                    list.AddFirst(Convert.ToInt32(valueNode));
                }
                else
                {
                    list.AddLast(Convert.ToInt32(valueNode));
                }

            }
            return list;
        }

        public static string FindElementByIndex(LinkedList<int> list, int index)
        {
            if (list.Count < index)
                return "NIL";
            else
            {
                var node = list.First;
                for (int i = 0; i < list.Count - index; i++)
                {
                    node = node.Next;
                }
                return node.Value.ToString();
            }
        }
    }
}