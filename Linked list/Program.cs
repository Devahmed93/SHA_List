using System;

namespace Linked_list
{
    class Program
    {
        static void Main(string[] args)
        {

            list<int> l = new list<int>();
            l.add(5);
            l.add(4);
            l.add(3);
            l.add(2);
            l.display();

            Console.WriteLine("////////////////////////////");
            l.sort(l);
         
            l.display();
           

        }
    }
}
