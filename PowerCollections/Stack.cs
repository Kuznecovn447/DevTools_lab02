using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PowerCollections
{
    internal class Stack<T>
    {
        private T[] stack;
        private int count;
        private int capacity;

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Length - 1; i > -1 ; i--)
            {
                yield return stack[i];
            }
        }

        public Stack(int maxSize)
        {
            capacity = maxSize;
            stack = new T[capacity];
        }

        public Stack(T[] array, int maxSize)
        {
            if(array.Length > maxSize)
                capacity = array.Length;
            else
                capacity = maxSize;
            stack = array;
            count = stack.Length; 
        }

        public int Count 
        {
            get { return count; } 
        }

        public int Capacity 
        {
            get { return capacity; }
        }

        public void Push(T element)
        {
            stack[count] = element;
            count++;
        }

        public T Top()
        {
            T element = stack[count - 1];
            return element;
        }

        public T Pop()
        {
            T element = stack[count - 1];
            Array.Copy(stack, stack, count - 1);
            count--;
            return element;
        }

        public void Clear()
        {
            count = 0;
            stack = new T[capacity];
        }

    }
}
