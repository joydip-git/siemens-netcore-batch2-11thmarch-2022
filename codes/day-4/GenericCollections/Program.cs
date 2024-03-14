namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);//1
            list.Add(2);//2
            list.Add(1);//3
            list.Add(3);//4

            //indexposition<= no of elements present in the list
            list.Insert(0, 20);//0
            list.Remove(1);
            list.RemoveAt(0);//index position as an argument

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(12);
            stack.Push(4);
            stack.Push(7);
            //stack.Pop();
            //stack.Peek();
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(12);
            queue.Enqueue('a');
            queue.Enqueue(2);
            queue.Enqueue(10);
            //queue.Dequeue();
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n\n");
           
            //it does not sort the keys
            Dictionary<int,string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "bangalore"); //{Key:1, Value:"bangalore"} => KeyValuePair<int,string>

            //keyValuePairs.Add(1, "siemens");
            keyValuePairs[1] = "Ecity";
            keyValuePairs[0] = "siemens";
            //keyValuePairs.Remove(1);

            //keyValuePairs.ContainsKey(2);
            //keyValuePairs.ContainsValue("siemens");
            //keyValuePairs.Keys;
            //keyValuePairs.Values;

            foreach (KeyValuePair<int,string> item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            //it sorts the keys
            SortedList<int, string> sortedKeyValuePairs = new SortedList<int, string>();
            sortedKeyValuePairs.Add(1, "bangalore"); //{Key:1, Value:"bangalore"} => KeyValuePair<int,string>

            //sortedKeyValuePairs.Add(1, "siemens");
            sortedKeyValuePairs[1] = "Ecity";
            sortedKeyValuePairs[0] = "siemens";
            //keyValuePairs.Remove(1);

            foreach (KeyValuePair<int, string> item in sortedKeyValuePairs)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }
    }
}
