using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class AVL :IProgram
    {
        public void Run()
        {
            Node root = null;
            
            Console.WriteLine("Enter the number of nodes");
            int t = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < t; i++)
            {
                int val = int.Parse(Console.ReadLine());

                root = InsertNode(root, val);
                root = BalanceTree(root);
            }
        }

        Node InsertNode(Node node, int val)
        {
            if(node == null)
                return new Node(val);


            if(node.Data > val)
                if(node.LeftNode == null)
                    node.LeftNode = new Node(val);
                else
                    node.LeftNode = InsertNode(node.LeftNode, val);
            else
                if(node.RightNode == null)
                    node.RightNode = new Node(val);
                else
                    node.RightNode = InsertNode(node.RightNode, val);

            return node;
        }

        Node BalanceTree(Node root)
        {
            int balanceFactor = GetHeight(root.LeftNode) - GetHeight(root.RightNode);
            if(balanceFactor < -1) // Right heavy
            {
                if(root.RightNode != null)
                {
                    Node child = root.RightNode;
                    int childBalanceFactor = GetHeight(child.LeftNode) - GetHeight(child.RightNode);
                    if(childBalanceFactor > 0)
                        root = LeftRightRotation(root);
                    else
                        root = LeftRotation(root);
                }
            }
            else if(balanceFactor > 1) // Left heavy
            {
                if(root.LeftNode != null)
                {
                    Node child = root.LeftNode;
                    int childBalanceFactor = GetHeight(child.LeftNode) - GetHeight(child.RightNode);
                    if(childBalanceFactor > 0)
                        root = RightLeftRotation(root);
                    else
                        root = RightRotation(root);
                }
            }

            return root;
        }

        int GetHeight(Node node)
        {
            if(node == null)
                return 0;
            else
                return 1 + Math.Max(GetHeight(node.LeftNode), GetHeight(node.RightNode));
        }

        Node LeftRightRotation(Node root)
        {
            root.RightNode = RightRotation(root.RightNode);
            return LeftRotation(root);
        }

        Node LeftRotation(Node root)
        {
            Node newRoot = root.RightNode;
            root.RightNode = newRoot.LeftNode;
            newRoot.LeftNode = root;

            return newRoot;
        }

        Node RightLeftRotation(Node root)
        {
            root.LeftNode = LeftRotation(root.LeftNode);
            return RightRotation(root);
        }

        Node RightRotation(Node root)
        {
            Node newRoot = root.LeftNode;
            root.LeftNode = newRoot.RightNode;
            newRoot.RightNode = root;

            return newRoot; 
        }
    }
}
