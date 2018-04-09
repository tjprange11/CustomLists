using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLists
{
     public class CustomLists<T>
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
        public T ElementAt(int index)
        {
            T value = array[index];
            return value;
        }
        public void Add(T element)
        {
            array[count] = element;
            count++;
        }
        public void Remove(int index)
        {
            for(int i = index;i < count - 1;i++)
            {
                array[i] = array[i + 1];
            }
            count--;
        }

        
    }
}
