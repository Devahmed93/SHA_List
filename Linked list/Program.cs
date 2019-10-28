using System;

namespace Linked_list
{
    class Program
    {
        static void Main(string[] args)
        {

            list<String> l = new list<String>();
            l.add("a");
            l.add("b");
            l.add("c");
            l.display();

            Console.WriteLine("////////////////////////////");
            l.Delete("b");
         
            l.display();
            Console.WriteLine(l.getcount());

        }
    }
}
