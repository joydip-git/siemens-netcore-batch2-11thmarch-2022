using System.Collections;

namespace GenericCollections
{
    internal class MyList<T> : IList<T>
    {
        T[] values;
        static int count = 0;

        public MyList()
        {
            values = new T[4];
        }

        public T this[int index]
        {
            get => values[index];
            set => values[index] = value;
        }

        public int Count => count;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if (count == values.Length)
            {
                T[] temp = new T[values.Length];
                values.CopyTo(temp, 0);
                values = new T[values.Length * 2];
                temp.CopyTo(values, 0);
                WeakReference < T[]> weakReference = new WeakReference<T[]>(temp);                
            }
            values[count] = item;
            count++;
        }

        public void Clear()
        {

        }

        public bool Contains(T item)
        {
            return true;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return values[i];
            }
        }

        public int IndexOf(T item)
        {
            return 0;
        }

        public void Insert(int index, T item)
        {

        }

        public bool Remove(T item)
        {
            return true;
        }

        public void RemoveAt(int index)
        {

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return values[i];
            }
        }
    }
}
