using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class BinarySearchTree : IProgram
    {
        public void Run()
        {
            Console.WriteLine("Select the operation: ");
            Console.WriteLine("1. Serialize Tree");
            Console.WriteLine("2. Deserialize");
            int option = Convert.ToInt32(Console.ReadLine());

            Node node = new Node
            {
                Data = 50,
                LeftNode = new Node
                {
                    Data = 30,
                    LeftNode = new Node { Data = 15 },
                    RightNode = new Node
                    {
                        Data = 35,
                        RightNode = new Node
                        {
                            Data = 40,
                            LeftNode = new Node { Data = 36 }
                        }
                    }
                },
                RightNode = new Node
                {
                    Data = 70,
                    RightNode = new Node { Data = 90 }
                }
            };
            string serializedTree = "50 30 15 35 40 36 70 90";
            switch (option)
            {
                case 1:
                    Console.WriteLine(Serialize(node));
                    break;
                case 2:
                    TreeTraversals app = new TreeTraversals();
                    app.Node = Deserialize(serializedTree);
                    app.Run();
                    break;
            }

            Console.ReadLine();
        }

        //Expected 50 30 15 35 40 36 70 90
        string Serialize(Node node)
        {
            StringBuilder items = new StringBuilder();
            items.Append(node.Data.ToString());// string.Format("{0} ", node.Data.ToString());
            if (node.LeftNode != null)
                items.Append(Serialize(node.LeftNode));
            if (node.RightNode != null)
                items.Append(Serialize(node.RightNode));

            return items.ToString();
        }


        Node Deserialize(string items)
        {
            int[] values = Array.ConvertAll(items.Split(' '), int.Parse);
            Node root = CreateTree(values, 0, values.Length-1);

            return root;
        }

        Node CreateTree(int[] items, int start, int end)
        {
            if (start > end)
                return null;

            Node root = new Node { Data = items[start] };
            if (start == end)
                return root;
            
            int endIndex = GetEndIndex(items, items[start], start);
            root.LeftNode = CreateTree(items, start + 1, endIndex);
            root.RightNode = CreateTree(items, endIndex + 1, end);
            return root;
        }

        int GetEndIndex(int[] items, int comparer, int startIndex)
        {
            int index = startIndex;
            for (int i = index+1; i < items.Length - 1; i++)
            {
                if (comparer > items[i])
                    index++;
                else
                    break;
            }
            return index;
        }
    }
}
