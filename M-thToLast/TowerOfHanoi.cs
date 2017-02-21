using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class TowerOfHanoi : IProgram
    {
        public void Run()
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            Stack<int> stack3 = new Stack<int>();

            Console.Write("Enter the number of discs: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                stack1.Push(i);
            }

            MoveDisks(n, stack1, stack3, stack2);

            while (stack3.Count > 0)
                Console.Write("{0} ", stack3.Pop());


            Console.WriteLine("END");
            Console.ReadLine();
        }

        static void MoveDisks(int n, Stack<int> origin, Stack<int> destination, Stack<int> buffer)
        {
            if (n > 0)
            {
                MoveDisks(n - 1, origin, buffer, destination);
                //int disk = origin.Peek();
                //if(!destination.IsEmpty && destination.Peek() < disk)
                //return;

                int disk = origin.Pop();
                destination.Push(disk);

                MoveDisks(n - 1, buffer, destination, origin);
            }

        }
    }
}
