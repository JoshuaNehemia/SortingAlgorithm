using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    public class Heap
    {
        #region DATA MEMBER
        private int[] heapArray;


        #endregion
        #region CONSTRUCTOR
        public Heap(int[] dataset) 
        {
            this.HeapArray = Heapify(dataset);
        }
        #endregion
        #region PROPERTIES
        public int[] HeapArray { get => heapArray; set => heapArray = value; }
        #endregion
        #region METHOD
        /// <summary>
        /// Creating a heap from a dataset
        /// </summary>
        public static int[] Heapify(int[] dataset)
        {
            int size = dataset.Length;
            int[] result = new int[size];
            




            return result;
        }




        /// <summary>
        /// Pushing a key to upper part of heap
        /// </summary>
        public static void PushUp()
        {

        }
        #endregion

        /// <summary>
        /// Pushing a key to lower part of heap
        /// </summary>
        public static void PushDown()
        {

        }
    }
}
