
namespace CollectionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine() ?? "";
            SortedList<string, int> result = CountWordsAndTheirFrequency(sentence);
            foreach (KeyValuePair<string,int> entry in result)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }

        private static SortedList<string, int> CountWordsAndTheirFrequency(string sentence)
        {
            if (sentence == null || sentence == string.Empty)
                throw new ArgumentException("sentence is either null or empty");

            SortedList<string, int> wordFrequencyCollection = new SortedList<string, int>();

            char[] separators = GetSeparators(sentence);
            if (!(separators.Length > 0))
            {
                wordFrequencyCollection.Add(sentence,1);
            }

            string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);            
            
            foreach (string word in words)
            {
                string temp = word.ToLower();
                if (wordFrequencyCollection.ContainsKey(temp))
                {
                    wordFrequencyCollection[temp]++;
                }else
                    wordFrequencyCollection.Add(temp, 1);
            }

            return wordFrequencyCollection;
        }

        private static char[] GetSeparators(string sentence)
        {
            HashSet<char> separators = new HashSet<char>();
            foreach (char c in sentence)
            {
                if (!char.IsLetterOrDigit(c))
                    separators.Add(c);
            }
            return separators.ToArray();
        }
    }
}
