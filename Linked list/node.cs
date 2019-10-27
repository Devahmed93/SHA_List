using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_list
{
    class node<T>
    {
        T data;
        node<T> next;
        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        public node <T> Next
        {
            get { return next; }
            set { next = value; }
        }
        public node(T d)
        {
            data = d;
            next = null;
        }
    }
}
