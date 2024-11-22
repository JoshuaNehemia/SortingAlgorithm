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
        public static void CheckNextNode(ref Node tempBufs, Node helper)
        {

            while (helper.Next != null)
            {
                if (helper.Next.Key > tempBufs.Key)
                {
                    //Insert Node
                    tempBufs.Next = helper.Next;
                    helper.Next = tempBufs;
                    return;
                }
                helper = helper.Next;
            }
            helper.Next = tempBufs;
        }

        public static int[] TranslateToArray(SinglyLinkedList list, int size)
        {
            int[] result = new int[size];
            //To Convert Node.Key into an array of int
            Node transfer = list.Head;
            int counter = 0;
            while (transfer.Next != null)
            {
                result[counter] = transfer.Key;
                counter++;
                transfer = transfer.Next;
            }
            result[counter] = transfer.Key;
            return result;
        }
        #endregion

    }
}
