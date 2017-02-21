using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(String[] args)
        {
            bool continueTheProgram = false;
            do
            {
                Orquestrator();
                
                Console.WriteLine("\nPress any key to exit or 'y' if you want to continue");
                continueTheProgram = Console.ReadLine().ToLower().Equals("y");

            } while (continueTheProgram);
        }

        public static void Orquestrator()
        {
            Console.WriteLine("Select the program you want to run");
            Console.WriteLine("1. M-th to last");
            Console.WriteLine("2. Ladders and Snakes");
            Console.WriteLine("3. Utopian Tree");
            Console.WriteLine("4. Pangrams");
            Console.WriteLine("5. Tree Traversals");
            Console.WriteLine("6. Dynamic Arrays *Not working*");
            Console.WriteLine("7. 2D Array");
            Console.WriteLine("8. Spare Arrays");
            Console.WriteLine("9. Distances");
            Console.WriteLine("10. Bit Manipulation");
            Console.WriteLine("11. Binary Search Tree");
            Console.WriteLine("12. Array list");
            Console.WriteLine("13. Tower of Hanoi");
            Console.WriteLine("14. AVL Trees");

            var option = Convert.ToInt32(Console.ReadLine());
            IProgram program;
            switch (option)
            {
                case 1:
                    program = new MthToLast();
                    break;
                //case 2:
                //    //program = new SnakesAndLadders();
                //    break;
                case 3:
                    program = new UtopianTree();
                    break;
                case 4:
                    program = new Pangrams();
                    break;
                case 5:
                    program = new TreeTraversals();
                    break;
                case 6:
                    program = new DynamicArray();
                    break;
                case 7:
                    program = new _2DArray();
                    break;
                case 8:
                    program = new SparesArrays();
                    break;
                case 9:
                    program = new Distances();
                    break;
                case 10:
                    program = new BitManipulation();
                    break;
                case 11:
                    program = new BinarySearchTree();
                    break;
                case 12:
                    program = new ArrayList();
                    break;
                case 13:
                    program = new TowerOfHanoi();
                    break;
                case 14:
                    program = new AVL();
                    break;
                default:
                    program = new MthToLast();
                    break;
            }

            program.Run();
        }
    }
}

