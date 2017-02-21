using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class TreeTraversals : IProgram
    {
        public Node Node { get; set; }

        public void Run()
        {
            int option = 0;
            if (Node == null)
            {
                Console.WriteLine("Select the option to fill the tree:");
                Console.WriteLine("1. Unordered dummy numbers");
                Console.WriteLine("2. Custom numbers in a Binary Search Tree");
                Console.WriteLine("");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Node = FillTheTree();
                        break;
                    case 2:
                        Node = FillBinarySearchTree();
                        break;
                    default:
                        Node = FillTheTree();
                        break;
                }
            }

            bool continueTheProgram = false;
            do
            {
                //Node root = FillTheTree(values);
                Console.WriteLine("Select the traversal: ");
                Console.WriteLine("1. Preorder");
                Console.WriteLine("2. Inorder");
                Console.WriteLine("3. Postorder");

                option = Convert.ToInt32(Console.ReadLine());
                string s = string.Empty;
                switch (option)
                {
                    case 1:
                        Preorder(Node);
                        break;
                    case 2:
                        string[] x1 = Inorder(Node).Split(' ');

                        var index1 = Array.FindIndex(x1, node => node == "2");
                        var index2 = Array.FindIndex(x1, node => node == "4");

                        var distance = (index1 - index2) > 0 ? (index1 - index2) : (index2 - index1);
                        break;
                    case 3:
                        string[] x = Postorder(Node).Split(' ');

                        var index3 = Array.FindIndex(x, node => node == "2");
                        var index4 = Array.FindIndex(x, node => node == "4");

                        var distance2 = (index3 - index4) > 0 ? (index3 - index4) : (index4 - index3);
                        break;

                }

                Console.WriteLine("\nPress any key to exit or 'y' if you want to continue in this program using the same tree");
                continueTheProgram = Console.ReadLine().ToLower().Equals("y");
            } while (continueTheProgram);
        }

        private Node FillTheTree()
        {
            //
            
            //Temporary dummy fill
            Node root = new Node
            {
                Data = 5,
                LeftNode = new Node
                {
                    Data = 3,
                    LeftNode = new Node
                    {
                        Data = 1,
                        RightNode = new Node
                        {
                            Data = 2
                        }
                    },
                    RightNode = new Node
                    {
                        Data = 4
                    }
                },
                RightNode = new Node
                {
                    Data = 6
                }
            };

            return root;
        }

        private Node FillBinarySearchTree()
        {
            Console.WriteLine("Please enter the values of the nodes");
            int[] values = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c)).ToArray();

            Node root = new Node { Data = values[0] };

            for (int i = 1; i < values.Length; i++)
            {
                InsertNode(root, values[i]);
            }

            return root;
        }

        private void InsertNode(Node root, int value)
        {
            if (root.Data > value)
            {
                if (root.LeftNode != null)
                    InsertNode(root.LeftNode, value);
                else
                    root.LeftNode = new Node { Data = value };
            }
            else
            {
                if (root.RightNode != null)
                    InsertNode(root.RightNode, value);
                else
                    root.RightNode = new Node { Data = value };
            }
        }

        private string Postorder(Node root)
        {
            StringBuilder items = new StringBuilder();
            
            if (root.LeftNode != null)
                items.Append(Postorder(root.LeftNode));

            if (root.RightNode != null)
                items.Append(Postorder(root.RightNode));


            items.Append(string.Format("{0} ", root.Data));
            Console.Write("{0} ", root.Data);

            return items.ToString();
        }

        private string Inorder(Node root)
        {
            StringBuilder items = new StringBuilder();

            if (root.LeftNode != null)
                items.Append(string.Format("{0} ", Inorder(root.LeftNode)));

            items.Append(string.Format("{0} ", root.Data));
            Console.Write("{0} ", root.Data);

            

            if (root.RightNode != null)
                items.Append(string.Format("{0} ", Inorder(root.RightNode)));

            return items.ToString();
        }

        private void Preorder(Node root)
        {
            Console.Write("{0} ", root.Data);

            if (root.LeftNode != null)
                Preorder(root.LeftNode);
            if (root.RightNode != null)
                Preorder(root.RightNode);
        }
    }

    class Node
    {
        public Node() { }

        public Node(int data)
        {
            Data = data;
        }

        public int Data;
        public Node LeftNode;
        public Node RightNode;
    }
}
