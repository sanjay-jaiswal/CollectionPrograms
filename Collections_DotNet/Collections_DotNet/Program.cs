using System;
using System.Collections.Generic;

namespace Collections_DotNet
{
    public static class CollectionDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================== Welcome To Collections Program ========================");
            CollectionDemo.ListDemo();
            CollectionDemo.HashSetDemo();
            CollectionDemo.QueueDemo();
            CollectionDemo.DictionaryDemo();
            CollectionDemo.StackDemo();

        }

        /// <summary>
        /// List implementation
        /// </summary>
        private static void ListDemo()
        {
            Console.WriteLine("\n========= Displaying List Data ========== ");

            List<string> list = new List<string>();
            list.Add("ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }


        public static void HashSetDemo()
        {
            Console.WriteLine("============= Displaying HashSet Data ============ ");
            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Raj");
            set.Add("Ajay");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }


        }


        public static void QueueDemo()
        {
            Queue<string> queue = new Queue<string>();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay raj");
            queue.Enqueue("Jaishankar");
            queue.Enqueue("Kohli");

            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\n===========Displaying the queue elments=========== ");
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }

            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue elements:" + dequeue);
            Console.WriteLine("========Iterating the queue element after dequeue one element to Display======");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        private static void DictionaryDemo()
        {
            Console.WriteLine("=========== Displaying Dictionary Data ============= ");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Vijay");

            Console.WriteLine("Access the value using key(key=100) :" + dictionary[100]);
            Console.WriteLine("\nDictionary data in key-value pair format :  ");
            //Iterating dictionary
            foreach (var element in dictionary)
            {
                Console.WriteLine("Key =" + element.Key + "& value =" + element.Value);
            }
        }

        private static void StackDemo()
        {
            Console.WriteLine("============== Displaying Stack Data ============= ");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garima");
            //string pop = stack.Pop();
            //Console.WriteLine("Poped element is :" + pop);

            foreach (var element in stack)
            {
                Console.WriteLine("Elements after pop operation are : "+element+",");
            }
        }
    }
}