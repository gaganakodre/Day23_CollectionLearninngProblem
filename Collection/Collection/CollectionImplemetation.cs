using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Collection
    {
        public void AddingList()
        {//list is a collection which as strogly typed objects CAN BE ASSCESSED BY THE INDEX
            List<string>List1=new List<string>();
            List1.Add("gowri");
            List1.Add("devag");
            List1.Add("jonny");
            List1.Contains("gowri");
            List1.Remove("gowri");
            foreach(var elements in List1)
            {
                Console.WriteLine(elements);
            }
        }
        //dictionary is a collection which will store the data in the form of key value pairs
        //and here it will store the data of same type under this name space using System.Collections.Generic
        public void AddDictionary()
        {
            Dictionary<int,string>Dictionary1=new Dictionary<int, string>();
            Dictionary1.Add(1,"Amit");
            Dictionary1.Add(2, "Ajay");
            Dictionary1.Add(3, "Anu");
            //Console.WriteLine("Access value using key(key=1):" + Dictionary1);
            Console.WriteLine("\niterating");
            foreach(var elements in Dictionary1)//here to print the dictonary we aer iterating through the dictionary using foreach loop
            {
                Console.WriteLine("key="+elements.Key+ " & Value="+elements.Value);
            }
        }
        public void AddStack()//uses LIFO=LAST IN FIRST OUT
        {//it is a collection and also data sturcture it will store the data in the form of lifo
            Stack<string>Stack1=new Stack<string>();
            Stack1.Push("gowri");//push and pop are already defined methods in the stack
            Stack1.Push("anu");
            Stack1.Push("chin");
            Stack1.Push("reva");
            string pop=Stack1.Pop();
            foreach(var elements in Stack1)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine("poped elements:" + pop);

        }
        public void AddLinkList()//linkedlist is also collection and also data structure in which we can store the data in the linear passion
        {//here we are creating the linked list of type string
            LinkedList<string>linkedList=new LinkedList<string>();
            linkedList.AddLast("Gowri");//add last is a built in method inside the linkedlist

        }
        public void AddQueue()
        {//queue is a collection and also data structure which store the value in the form of FIFO manner
            Queue<string>queue=new Queue<string>();
            queue.Enqueue("Anu");
            queue.Enqueue("vijay");
            queue.Enqueue("vinay");
            queue.Enqueue("sharma");
            queue.Enqueue("raju");
            Console.WriteLine("Head:" + queue.Peek());//peek display top elemnts in stack or queue
            Console.WriteLine("\niterating trough the queue");
            foreach(var elements in queue)
            {
                Console.WriteLine(elements);
            }
            string dequeue=queue.Dequeue();
            Console.WriteLine("\nDequeue elements"+dequeue);
            //iterating queue elements using enumerator method
            Queue<string>.Enumerator enumarator=queue.GetEnumerator();
            while(enumarator.MoveNext())//it return s bool values and it advances the
                                        
                                        //enumarator to the next element in the queue
            {
                Console.WriteLine(enumarator.Current);//gets the elements at the current position of the enumaretor
                                                      //and returns the same elements
            }
        }
    }
}
