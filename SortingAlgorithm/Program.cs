using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace SortingAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sementara untuk testing 1 metode sorting saja
            #region INPUT
            Console.WriteLine("INPUT : ");
            string input = Console.ReadLine();
            string[] buffer = input.Split(' ');
            int size = buffer.Length; 
            int[] dataset = new int[size];
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                dataset[i] = int.Parse(buffer[i]);
            }
            #endregion


            #region SELECT METHOD OF SORTING
            // the code that you want to measure 
            result = Solution.SinglyLinkedListSort(dataset);
            #endregion

            #region OUTPUT
            Console.WriteLine("OUTPUT : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(result[i] + " ");
            }

            #region PERFORMANCE
            AccuracyTester(result, size);
            #endregion
            Console.ReadLine();
            #endregion
        }

        static void AccuracyTester(int[] result, int size)
        {
            //Accuracy tester for debugging purposes
            double counter = 1;
            double accuracy;
            for (int i = 0; i < size - 1; i++)
            {
                if (result[i] <= result[i + 1])
                {
                    counter++;
                }
            }
            accuracy = counter / size;
            Console.WriteLine("");
            Console.WriteLine("Accuracy : " + (accuracy * 100) + "% (" + counter + "/" + size + ")");
        }
    }
}
