using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_of_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of test-cases: ");
            int n = int.Parse(Console.ReadLine());
            int[] result = new int[n];
            int sum;
            /*for (int i = 0; i < n; i++)
            {
                Console.Write("Enter quantity of values for array: ");
                quantity = int.Parse(Console.ReadLine());
                int[] arr1 = new int[quantity];
                Console.WriteLine("Enter values for array: ");
                for (int j = 0; j < quantity; j++)
                {
                    arr1[j] = int.Parse(Console.ReadLine());
                    sum += arr1[j];
                }
                mean = sum / quantity;
            }
            Console.Write(mean);*/
            for (int i = 0; i < n; i++)
            {
                sum = 0;
                int[] arr = CreateArray();
                for (int j = 0; j < arr.Length; j++)//calculate sum of array
                {
                    sum += arr[j];
                }
                result[i] = sum / arr.Length;
            }
            for (int i = 0; i < n; i++)//show results
            {
                Console.Write(result[i] + " ");
            }
            Console.ReadKey();
        }

        static int[] CreateArray()//method to create and fill array as we do not know how many arrays will be
        {
            Console.Write("Enter quantity of values for array: ");
            int quantity = int.Parse(Console.ReadLine());
            int[] arr = new int[quantity];
            Console.WriteLine("Enter values for array: ");
            for (int i = 0; i < quantity; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
    }
}
