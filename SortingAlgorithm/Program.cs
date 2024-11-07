using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

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
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure 
            result = Solution.SinglyLinkedListSort(dataset);
            watch.Stop();
            double elapsedMs = watch.ElapsedMilliseconds;
            #endregion

            #region OUTPUT
            Console.WriteLine("OUTPUT : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(result[i] + " ");
            }

            #region Performance Checker
            //Accuracy tester
            double counter =1;
            double accuracy;
            for ( int i=0; i< size-1;i++)
            {
                if (result[i] <= result[i+1])
                {
                    counter++;
                }
            }
            accuracy = counter / size;
            Console.WriteLine("");
            Console.WriteLine("Accuracy : " + (accuracy*100) + "% (" + counter + "/"+size+")");
            Console.WriteLine("Time elapsed : " + elapsedMs + " ms");
            #endregion
            Console.ReadLine();
            #endregion
        }
    }
}
