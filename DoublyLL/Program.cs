using System;

namespace DoublyLL
{
   
        public class LinkedList
        {

            static Node head;

            class Node
            {

                public int data;
                public Node next, prev;

                public Node(int d)
                {
                    data = d;
                    next = prev = null;
                }
            }

            /* Function to reverse a Doubly Linked List */
            void reverse()
            {
                Node temp = null;
                Node current = head;

                /* swap next and prev for all nodes of  
                doubly linked list */
                while (current != null)
                {
                    temp = current.prev;
                    current.prev = current.next;
                    current.next = temp;
                    current = current.prev;
                }

                /* Before changing head, check for 
                  the cases like empty list and 
                 list with only one node */
                if (temp != null)
                {
                    head = temp.prev;
                }
            }

            /* UTILITY FUNCTIONS */
            /* Function to insert a node at the  
            beginging of the Doubly Linked List */
            void push(int new_data)
            {

                /* allocate node */
                Node new_node = new Node(new_data);

                /* since we are adding at the beginning,  
                prev is always NULL */
                new_node.prev = null;

                /* link the old list off the new node */
                new_node.next = head;

                /* change prev of head node to new node */
                if (head != null)
                {
                    head.prev = new_node;
                }

                /* move the head to point to the new node */
                head = new_node;
            }

            /* Function to print nodes in a given 
            doubly linked list This function is 
            same as printList() of singly linked lsit */
            void printList(Node node)
            {
                while (node != null)
                {
                    Console.Write(node.data + " ");
                    node = node.next;
                }
            }

            // Driver code 
            public static void Main(String[] args)
            {
                LinkedList list = new LinkedList();

                /* Let us create a sorted linked list  
                to test the functions Created linked  
                list will be 10->8->4->2 */
                list.push(2);
                list.push(4);
                list.push(8);
                list.push(10);

                Console.WriteLine("Original linked list ");
                list.printList(head);

                list.reverse();
                Console.WriteLine("");
                Console.WriteLine("The reversed Linked List is ");
                list.printList(head);
            }
        
    }
}
