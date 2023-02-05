using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPrograms
{
    public class Collections
    {
       public static void dosetDemo()
       {
            Console.WriteLine("HashSet");
            var set=new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Ajay");
            HashSet<string>.Enumerator enumerator=set.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        
       }
        public static void doqueueDemo()
        {
            Console.WriteLine("Queue and Dequeue Program");
            Queue<string> queue=new Queue<string>();
            Dictionary<int,string>dictionary=new Dictionary<int,string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay Raj");
            queue.Enqueue("Jaishankar");
            queue.Enqueue("Raj");
            Console.WriteLine("Head:"+queue.Peek());
            Console.WriteLine("Iterating the queue elements:");
            foreach(var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue=queue.Dequeue();
            Console.WriteLine("Dequeue element:"+dequeue);
            Console.WriteLine("Iterating the queue elements after dequeue one element");
            Queue<string>.Enumerator enumerator=queue.GetEnumerator();
            while(enumerator.MoveNext()) 
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        
        public static void doDictionaryDemo()
        {
            Console.WriteLine("Dictionary Program");
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Vijay");
            Console.WriteLine("Access value using key(key=100):" + dictionary[100]);
            Console.WriteLine("Iterating Dictionary");
            foreach(var element in dictionary)
            {
                Console.WriteLine("Key="+element.Key+"& Value="+element.Value);
            }
        }

        public static void DoStackDemo()
        {
            Console.WriteLine("Stack Program");
            Stack<String>stack= new Stack<String>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garina");
            String pop=stack.Pop();
            foreach(var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("poped element:"+pop);
        }

        public static void DoListDemo()
        {
            Console.WriteLine("List Program");
            List<String>list = new List<String>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");
            foreach(var element in list)
            {
                Console.WriteLine(element);

            }
        }

    }
}
