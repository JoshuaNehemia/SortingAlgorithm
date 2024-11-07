using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    public class Node
    {
        #region DATA MEMBER
        private int key;
        private Node next;
        #endregion
        #region CONSTRUCTOR
        public Node(int input_key, Node input_next)
        {
            this.Key = input_key;
            this.Next = input_next;
        }
        #endregion
        #region PROPERTIES
        public int Key 
        { 
            get => key; 
            set
            {
                if(value <0)
                {
                    throw new Exception("Input Can't Be Negative");
                }
                else
                {
                    key = value;
                }
            }
        }
        public Node Next { get => next; set => next = value; }
        #endregion
    }
}
