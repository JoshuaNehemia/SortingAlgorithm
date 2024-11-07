using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm.SinglyLinkedListSort
{
    public class SinglyLinkedList
    {
        //Store a node as head
        #region DATA MEMBER
        private Node head;
        #endregion

        #region CONSTRUCTOR
        public SinglyLinkedList(Node input_head)
        {
            this.Head = input_head;
        }
        #endregion

        #region PROPERTIES
        public Node Head { get => head;set => head = value; }
        #endregion

        #region METHOD

        #endregion

    }
}
