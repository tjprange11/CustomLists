using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLists
{
     public class CustomLists<T> : IEnumerable<T>
    {
        //memeber variables
        T[] array;
        int count;
        int capacity;
        //constructor
        public CustomLists()
        {
            capacity = 20;
            array = new T[capacity];
            count = 0;
        }

        public CustomLists(int capacity)
        {
            this.capacity = capacity;
            array = new T[capacity];
            count = 0;
        }

        //member methods
        public int Count
        {
            get
            {
                return count;
            }
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public T ElementAt(int index)
        {
            T value = array[index];
            return value;
        }

        private void IncreaseArraySize()
        {
            T[] temporary = new T[capacity * 2];
            for(int i = 0;i < capacity; i++)
            {
                temporary[i] = array[i];
            }
            array = temporary;
            capacity *= 2;
        }

        public void Add(T element)
        {
            if(count == capacity/2)
            {
                IncreaseArraySize();
            }
            array[count] = element;
            count++;
        }

        private void MoveElementsForward(int index)
        {
            int i;
            for (i = index;i < count - 1;i++)
            {
                array[i] = array[i + 1];
            }
            array[i] = default(T);
        }

        public void Remove(T element)
        {
            for (int i = 0;i < count;i++)
            {
                if(element.Equals(array[i]))
                {
                    MoveElementsForward(i);
                    count--;
                    break;
                }
            }
        }

        public override string ToString()
        {
            return "";
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(T element in array)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public static CustomLists<T> operator +(CustomLists<T> list1, CustomLists<T> list2)
        {
            CustomLists<T> newList = list1;
            for(int i = 0;i < list2.Count; i++)
            {
                newList.Add(list2.ElementAt(i));
            }
            return newList;
        }

        public static CustomLists<T> operator -(CustomLists<T> list1, CustomLists<T> list2)
        {
            CustomLists<T> newList = list1;
            for (int i = 0; i < list2.Count; i++)
            {
                newList.Remove(list2.ElementAt(i));
            }
            return newList;
        }

        public CustomLists<T> ZipLists(CustomLists<T> list)
        {
            CustomLists<T> newList = new CustomLists<T>();
            for(int i = 0; i < count; i++)
            {
                newList.Add(array[i]);
                newList.Add(list[i]);
            }
            return newList;
        }

        private void SwithPosition(int indexOne, int indexTwo)
        {
            T temporary = array[indexOne];
            array[indexOne] = array[indexTwo];
            array[indexTwo] = temporary;
        }

    }
}
