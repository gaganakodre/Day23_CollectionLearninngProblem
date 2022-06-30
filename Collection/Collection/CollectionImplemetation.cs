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
        {
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
        public void AddDictionary()
        {
            Dictionary<int,string>Dictionary1=new Dictionary<int, string>();
            Dictionary1.Add(1,"Amit");
            Dictionary1.Add(2, "Ajay");
            Dictionary1.Add(3, "Anu");
            Console.WriteLine("Access value using key(key=1):" + Dictionary1);
            Console.WriteLine("\niterating");
            foreach(var elements in Dictionary1)
            {
                Console.WriteLine("key="+elements.Key+ " & Value="+elements.Value);
            }
        }
        public void AddStack()
        {
            Stack<string>Stack1=new Stack<string>();
            Stack1.Push("gowri");
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
        public void AddLinkList()
        {
            LinkedList<string>linkedList=new LinkedList<string>();
            linkedList.AddLast("Gowri");

        }
        public void AddQueue()
        {
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
            while(enumarator.MoveNext())
            {
                Console.WriteLine(enumarator.Current);
            }
        }
    }
}
