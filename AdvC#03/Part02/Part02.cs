using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_03.Part02
{
    internal class Part02<T>
    {
        public T[] Items;
        public int Count;
        public const int defaultCapacity = 4;
        public Part02(int count)
        {
            Count = count;
            Items = new T[defaultCapacity];
        }

        public T Find(Predicate<T> match)
        {
            for (int i = 0; i < Count; i++)
            {
                if (match(Items[i]))
                    return Items[i];
            }
            return default(T);
        }
        public List<T> FindAll(Predicate<T> match)
        {
            var result = new List<T>();
            for (int i = 0; i < Count; i++)
            {
                if (match(Items[i]))
                    result.Add(Items[i]);
            }
            return result;
        }
        public int FindIndex(Predicate<T> match)
        {
            for (int i = 0; i < Count; i++)
            {
                if (match(Items[i]))
                    return i;
            }
            return -1;
        }
        public int FindLastIndex(Predicate<T> match)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                if (match(Items[i]))
                    return i;
            }
            return -1;
        }
        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(Items[i]);
            }
        }
        public bool TrueForAll(Predicate<T> match)
        {
            for (int i = 0; i < Count; i++)
            {
                if (!match(Items[i]))
                    return false;
            }
            return true;
        }
        public bool Exists(Predicate<T> match)
        {
            for (int i = 0; i < Count; i++)
            {
                if (match(Items[i]))
                    return true;
            }
            return false;
        }

        public T FindLast(Predicate<T> match)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                if (match(Items[i]))
                    return Items[i];
            }
            return default(T);
        }

    }
}
