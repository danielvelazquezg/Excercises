using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class BitManipulation : IProgram
    {
        public void Run()
        {
            Console.WriteLine("Select the subprogram you want to run");
            Console.WriteLine("1. Lonely Integer");
            Console.WriteLine("2. Flipping Bits");
            Console.WriteLine("3. Maximizing XOR");
            Console.WriteLine("4. Game");

            var option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    LonelyInteger();
                    break;
                case 2:
                    FlippingBits();
                    break;
                case 3:
                    MaximizingXOR();
                    break;
                case 4:
                    Game();
                    break;
            }
        }

        private void MaximizingXOR()
        {
            Console.Write("Enter the minimum value: ");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the maximum value: ");
            int r = Convert.ToInt32(Console.ReadLine());

            int max = 0;
            for (int i = l; i <= r; i++)
            {
                for (int j = i; j <= r; j++)
                {
                    int t = i ^ j;
                    if (max < t)
                        max = t;
                }
            }

            Console.WriteLine(max);
        }

        private void FlippingBits()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            uint[] items = new uint[n];

            for (int i = 0; i < n; i++)
            {
                items[i] = Convert.ToUInt32(Console.ReadLine());
            }
        }

        private static void LonelyInteger()
        {
            Console.Write("Introduce the number of elements: ");
            int _a_size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[_a_size];
            int _a_item;

            Console.Write("Introduce the elements separated by a blank space: ");
            String move = Console.ReadLine();
            String[] move_split = move.Split(' ');
            for (int _a_i = 0; _a_i < move_split.Length; _a_i++)
            {
                _a_item = Convert.ToInt32(move_split[_a_i]);
                a[_a_i] = _a_item;
            }

            int value = 0;
            for (int i = 0; i < a.Length; i++)
                value = value ^ a[i];

            Console.WriteLine(value);
        }

        private static void Game()
        {
            var t = Convert.ToInt32(Console.ReadLine());
            ulong [] n = new ulong[t];

            for (int i = 0; i < t; i++)
            {
                n[i] = Convert.ToUInt64(Console.ReadLine());
            }


            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("{0}",
                    Steps(n[i]) % 2 == 0 ?
                    "Louise" : "Richard");
            }
        }

        private static int Steps(ulong n)
        {
            int i = 0;
            while (n > 1)
            {
                if (is_power_of_2(n))
                    n >>= 1;
                else
                    n -= (ulong)1 << largest_exp_of_2_less_than(n);
                i += 1;
            }
            return i - 1;
        }
        
        //private static bool IsEven(int n)
        //{
        //    return n % 2 == 0;
        //}

        private static bool is_power_of_2(ulong n)
        {
            return (n & (n - 1)) == 0;
        }


        private static int largest_exp_of_2_less_than(ulong n)
        {
            int exp = 0;
            while (n > 0)
            {
                n >>= 1;
                exp++;
            }
            return exp - 1;
        }

        private void Unused()
        {
            string[] array = { "", "", "" };
             //Array.ConvertAll<string, int>(array, new Convert<string, int>(num));
            int index = Array.IndexOf(array, "");
        }

    }
}
