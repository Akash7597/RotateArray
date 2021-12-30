using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate
{
    internal class Program
    {
        static void Main(string[] args)
        {

                int[] a = new int[100];
                Console.WriteLine("Elements aof array: ");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }

                int temp;
                for (int j = 0; j < a.Length - 1; j++)
                {
                    temp = a[0];
                    a[0] = a[j + 1];
                    a[j + 1] = temp;
                }
                Console.WriteLine("Rotated Elements: ");
                foreach (int num in a)
                {
                    Console.Write(num + " ");
                }
                Console.ReadKey();
        }
    }
}
