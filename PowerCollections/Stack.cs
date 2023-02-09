using System;
using System.Collections.Generic;

namespace Wintellect.PowerCollections
{
    [Serializable]
    public class Stack<T>
    {
        private T[] stack;
        private int count;
        private int capacity;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// <para>Equality between items is determined by the comparison instance or delegate used
        /// to create the set.</para>
        /// <para>Adding an item takes approximately constant time, regardless of the number of items in the set.</para></remarks>
        /// <returns>IEnumerator</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < stack.Length; i++)
            {
                yield return stack[i];
            }
        }

        /// <summary>
        ///     Adds a new item to the set. If the set already contains an item equal to
        ///     <paramref name="maxSize"/>, that item is replaced with <paramref name="maxSize"/>.
        /// </summary>
        /// <remarks>
        ///     <para>Equality between items is determined by the comparison instance or delegate used
        ///     to create the set.</para>
        ///     <para>Adding an item takes approximately constant time, regardless of the number of items in the set.</para>
        /// </remarks>
        /// <param name="maxSize">The item to add to the set.</param>
        /// <returns>Stack</returns>
        public Stack(int maxSize)
        {
            capacity = maxSize;
            stack = new T[capacity];
        }

        /// <summary>
        /// Adds a new item to the set. If the set already contains an item equal to
        /// <paramref name="item"/>, that item is replaced with <paramref name="item"/>.
        /// </summary>
        /// <remarks>
        /// <para>Equality between items is determined by the comparison instance or delegate used
        /// to create the set.</para>
        /// <para>Adding an item takes approximately constant time, regardless of the number of items in the set.</para></remarks>
        /// <param name="item">The item to add to the set.</param>
        /// <returns>True if the set already contained an item equal to <paramref name="item"/> (which was replaced), false 
        /// otherwise.</returns>
        public Stack(T[] array, int maxSize)
        {
            if(array.Length > maxSize)
                capacity = array.Length;
            else
                capacity = maxSize;
            stack = array;
            count = stack.Length; 
        }

        /// <summary>
        /// Adds a new item to the set. If the set already contains an item equal to
        /// <paramref name="item"/>, that item is replaced with <paramref name="item"/>.
        /// </summary>
        /// <remarks>
        /// <para>Equality between items is determined by the comparison instance or delegate used
        /// to create the set.</para>
        /// <para>Adding an item takes approximately constant time, regardless of the number of items in the set.</para></remarks>
        /// <param name="item">The item to add to the set.</param>
        /// <returns>True if the set already contained an item equal to <paramref name="item"/> (which was replaced), false 
        /// otherwise.</returns>
        public int Count 
        {
            get { return count; } 
        }

        /// <summary>
        /// Adds a new item to the set. If the set already contains an item equal to
        /// <paramref name="item"/>, that item is replaced with <paramref name="item"/>.
        /// </summary>
        /// <remarks>
        /// <para>Equality between items is determined by the comparison instance or delegate used
        /// to create the set.</para>
        /// <para>Adding an item takes approximately constant time, regardless of the number of items in the set.</para></remarks>
        /// <param name="item">The item to add to the set.</param>
        /// <returns>True if the set already contained an item equal to <paramref name="item"/> (which was replaced), false 
        /// otherwise.</returns>
        public int Capacity 
        {
            get { return capacity; }
        }

        /// <summary>
        /// Adds a new item to the set. If the set already contains an item equal to
        /// <paramref name="item"/>, that item is replaced with <paramref name="item"/>.
        /// </summary>
        /// <remarks>
        /// <para>Equality between items is determined by the comparison instance or delegate used
        /// to create the set.</para>
        /// <para>Adding an item takes approximately constant time, regardless of the number of items in the set.</para></remarks>
        /// <param name="item">The item to add to the set.</param>
        /// <returns>True if the set already contained an item equal to <paramref name="item"/> (which was replaced), false 
        /// otherwise.</returns>
        public void Push(T element)
        {
            stack[count] = element;
            count++;
        }

        /// <summary>
        /// Adds a new item to the set. If the set already contains an item equal to
        /// <paramref name="item"/>, that item is replaced with <paramref name="item"/>.
        /// </summary>
        /// <remarks>
        /// <para>Equality between items is determined by the comparison instance or delegate used
        /// to create the set.</para>
        /// <para>Adding an item takes approximately constant time, regardless of the number of items in the set.</para></remarks>
        /// <param name="item">The item to add to the set.</param>
        /// <returns>True if the set already contained an item equal to <paramref name="item"/> (which was replaced), false 
        /// otherwise.</returns>
        public T Top()
        {
            T element = stack[count - 1];
            return element;
        }

        /// <summary>
        /// Adds a new item to the set. If the set already contains an item equal to
        /// <paramref name="item"/>, that item is replaced with <paramref name="item"/>.
        /// </summary>
        /// <remarks>
        /// <para>Equality between items is determined by the comparison instance or delegate used
        /// to create the set.</para>
        /// <para>Adding an item takes approximately constant time, regardless of the number of items in the set.</para></remarks>
        /// <param name="item">The item to add to the set.</param>
        /// <returns>True if the set already contained an item equal to <paramref name="item"/> (which was replaced), false 
        /// otherwise.</returns>
        public T Pop()
        {
            T element = stack[count - 1];
            Array.Copy(stack, stack, count - 1);
            count--;
            return element;
        }

        /// <summary>
        /// Adds a new item to the set. If the set already contains an item equal to
        /// <paramref name="item"/>, that item is replaced with <paramref name="item"/>.
        /// </summary>
        /// <remarks>
        /// <para>Equality between items is determined by the comparison instance or delegate used
        /// to create the set.</para>
        /// <para>Adding an item takes approximately constant time, regardless of the number of items in the set.</para></remarks>
        /// <param name="item">The item to add to the set.</param>
        /// <returns>True if the set already contained an item equal to <paramref name="item"/> (which was replaced), false 
        /// otherwise.</returns>
        public void Clear()
        {
            count = 0;
            stack = new T[capacity];
        }
    }
}
