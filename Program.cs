using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos
{
    class Program
    {
        /// <summary>
        /// Used in Shuffle(T)
        /// </summary>
        static Random _random = new Random();

        static void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                //next double returns a random number between 0 and 1
                int r = i + (int)(_random.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;

            }
        }

        static void Main(string[] args)
        {
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Shuffle(array);
                foreach (int value in array)
                {
                    Console.WriteLine(value);
                }


            }

            {
                string[] array = { "dot", "net", "perls" };
                Shuffle(array);
                foreach(string value in array)
                {
                    Console.WriteLine(value);
                }

            }
            Console.ReadLine();
        }
    }
}
