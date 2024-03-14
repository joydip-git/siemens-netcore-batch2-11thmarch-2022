using System.Collections;

namespace CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //int[] arr = [1, 2, 3];
            //int[] arr2 = new int[5];
            //arr.CopyTo(arr2, 0);
            //arr = null;
            //foreach (int item in arr2)
            //{
            //    Console.WriteLine(item);
            //}

            ArrayList al = new ArrayList();
            al.Add(12); //object obj = 12;
            al.Add('a');
            al.Add("siemens");
            al.Add(12.34D);
            al.Add(12);
            Console.WriteLine(al.Capacity);
            al.Add(12.54M);
            al.Add(12.67F);
            al.Add(true);
            al.Add(false);
            Console.WriteLine(al.Capacity);

            //al.Insert()
            Console.WriteLine("\n\n\n");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            foreach (object item in al)
            {
                Console.WriteLine(item);
            }

            Stack stack = new Stack();
            stack.Push(12);
            stack.Push('a');
            stack.Push("siemens");
            stack.Push(12.34D);
            stack.Push(12);
            stack.Push(12.54M);
            stack.Push(12.67F);
            stack.Push(true);

            //to remove an element
            //stack.Pop();

            //to see which one is the last element
            //stack.Peek();

            //you can not use indexer to iterate through the Stack
            //for (int i = 0; i < stack.Count; i++)
            //{
            //    Console.WriteLine(stack[i]);
            //}
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }

            Queue queue = new Queue();
            queue.Enqueue(12);
            queue.Enqueue('a');
            queue.Enqueue("siemens");
            queue.Enqueue(12.34D);
            queue.Enqueue(12);
            queue.Enqueue(12.54M);
            queue.Enqueue(12.67F);
            queue.Enqueue(true);

            //to remove an element
            //queue.Dequeue();

            //you can not use indexer to iterate through the Queue
            //for (int i = 0; i < queue.Count; i++)
            //{
            //    Console.WriteLine(queue[i]);
            //}

            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }
            
            //keys need not be of similar types
            //it does not sort the keys
            Hashtable hashtable = new Hashtable();
            hashtable.Add("key1", 12); //{Key:key1, Value:12} => DictionaryEntry
            //hashtable.Add("key1", "siemens");
            hashtable["key1"] = 13;
            hashtable[0] = "siemens";
            //hashtable.Remove("key1");

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
            */

            //keys must be of similar types
            //it does not sort the keys
            SortedList sortedList = new SortedList();
            sortedList.Add(1, 12); //{Key:key1, Value:12} => DictionaryEntry
            //SortedList.Add("key1", "siemens");
            sortedList[1] = 13;
            sortedList[0] = "siemens";
            //SortedList.Remove("key1");

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }
    }
}
