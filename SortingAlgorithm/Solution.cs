using SortingAlgorithm.SinglyLinkedListSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SortingAlgorithm
{
    
    public class Solution
    {

        #region SINGLY LINKED LIST SORTING SOLUTION
        private static void CheckNextNode(ref Node tempBufs, Node helper)
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
        public static int[] SinglyLinkedListSort(int[] array)
        {   
            int size = array.Length;
            int[] result = new int[size];
            Node head = new Node(array[0], null);
            SinglyLinkedList list = new SinglyLinkedList(null);
            Node tempBuf;
            for (int i = 0; i < size; i++)
            {
                tempBuf = new Node(array[i], null);
                //Set First Item as Head
                if (i == 0)
                {
                    list.Head = tempBuf;
                }
                else
                {
                    Node helper = list.Head;
                    //Check List.head
                    if(list.Head.Key > tempBuf.Key)
                    {
                        //Insert Node as head and head.next refers to previous list.head
                        tempBuf.Next = list.Head;
                        Node buffer = tempBuf;
                        tempBuf = list.Head;
                        list.Head = buffer;
                    }
                    else
                    {
                        CheckNextNode(ref tempBuf, helper);
                    }
                }
            }
            //To Convert Node.Key into an array of int
            Node transfer = list.Head;
            int counter=0;
            while (transfer.Next != null) 
            {
                result[counter] = transfer.Key;
                counter++;
                transfer = transfer.Next;
            }
            result[counter] = transfer.Key;
            Console.WriteLine("Sorted With Singly Linked List");
            return result;
        }
        #endregion
    }
}
