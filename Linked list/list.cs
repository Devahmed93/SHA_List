using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_list
{
    class list<T>
    {
        node<T> head;
        node<T> tail;
        int count = 0;
        public list()
        {
            head = null;
            tail = null;
        }
        public void add(T x)
        {
            node<T> temp = new node<T>(x);
            if (head==null)
            {
                head = temp;
                tail = temp;
            }
            else
            {
                tail.Next = temp;
                tail = temp;
            }
            count++;
        }
        public void display()
        {
            if (head==null)
            {
                Console.WriteLine("list iss empty");
            }
            node<T> p = head;
            while(p!=null)
            {
                Console.WriteLine(p.Data);
                p = p.Next;
            }
        }
        public bool search(T d)
        {
            node<T> p = head;
            while (p!=null)
            {
                if (p.Data.Equals(d))
                {
                    return true;
                }
                p = p.Next;

            }
            return false;

        }
        public void clear()
        {
            head = tail = null;
            count = 0;
        }
        public bool Delete(T d)
        {
            node<T> current = head;
            node<T> prev = null;
            while (current!=null)
            {
                if (current.Data.Equals(d))
                {
                    if (prev==null)// the elemnt in First place
                    {
                        head = head.Next; //Delete it
                        if (head==null) // check if the list has only one node
                        {
                            tail = null; // clear list

                        }
                    }
                    else
                    {
                        prev.Next = current.Next; //Delete in the middle
                        if (current.Next==null)// if true the element in last posistion
                        {
                            tail = prev; // delete last element
                        }
                       

                    }
                    count--;
                    return true;

                }
                prev = current;
                current = current.Next;

            }
            return false;
        }
    }
}
