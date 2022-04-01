using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add("ABc");
            //arrayList.Add('a');
            //arrayList.Add(2.4);
            //arrayList.Add(2.4);
            //Console.WriteLine("ArrayList Items:");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(arrayList.Capacity);
            //arrayList.AddRange(arrayList);

            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(1, "0554222222");
            numberNames.Add(2, "0554222223");
            numberNames.Add(9, "0554222224");
            numberNames.Add(3, "0554222225"); 
            numberNames.Add(5, "0554222226");

            foreach (var item in numberNames)
            {
                Console.WriteLine("Key: {0} , value:{1}", item.Key ,item.Value);
            }
            Console.WriteLine("\n=======\n");
            Dictionary<string , string> names =new Dictionary<string, string>();

            names.Add("C", "Seymur1");
            names.Add("B", "Seymur2");
            names.Add("A", "Seymur3");
            names.Add("D", "Seymur4");
            names.Remove("C");
            foreach (var item in names)
            {
                Console.WriteLine("Key:{0} , Value:{1}", item.Key, item.Value);
            }
            Console.WriteLine("\n=======\n");

            Stack<int> nums = new  Stack<int>();
            nums.Push(1);
            nums.Push(2);
            nums.Push(3);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n=======\n");

            nums.Pop();
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n=======\n");

            Queue<int> queue = new Queue<int>();        

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n=======\n");
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }











        }
    }
}
