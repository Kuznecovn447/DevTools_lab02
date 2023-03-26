using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PowerCollections.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void stack_with_request_capacity_and_null_count_element()
        {
            Stack<int> stack = new Stack<int>(18);
            Assert.AreEqual(18, stack.Capacity);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void count_stack_after_add_element()
        {
            Stack<string> stack = new Stack<string>(4);
            stack.Push("Элемент 1");
            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void adding_an_array_to_the_stack()
        {
            string[] str = new string[] { "Nikita", "Denis", "Kirill" };
            Stack<string> stack = new Stack<string>(str, 10);
            Assert.AreEqual(3, stack.Count);
        }

        [TestMethod]
        public void return_top_element_from_stack()
        {
            Stack<int> stack = new Stack<int>(2);
            stack.Push(1);
            stack.Push(2);
            int result = stack.Top();
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void return_and_delete_top_element_from_stack()
        {
            Stack<string> stack = new Stack<string>(3);
            stack.Push("Denis");
            stack.Push("Nikita");
            string result = stack.Pop();
            Assert.AreEqual("Nikita", result);
            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void returning_a_clean_stack()
        {
            string[] str = new string[] { "Nikita", "Denis", "Kirill" };
            Stack<string> stack = new Stack<string>(str, 10);
            stack.Clear();
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void checking_interface_enumerable_topdown()
        {
            int[] numbers = new int[] { 1, 2, 3 };
            Stack<int> stack = new Stack<int>(numbers, 10);

            int i = 3;
            for (int el = stack.Count; el < 0; el--) 
            {
                Assert.AreEqual(i--, el);
            }
        }        

        [TestMethod]
        public void set_MaxSize_stack_ArrayLength_if_ArrayLength_more_StackLength()
        {
            string[] str = new string[] { "Nikita", "Denis", "Kirill" };
            Stack<string> stack = new Stack<string>(str, 1);
            Assert.AreEqual(3, stack.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void call_exception_if_stack_overflow()
        {
            Stack<string> stack = new Stack<string>(1);
            stack.Push("S");
            stack.Push("D");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void raise_an_exception_when_the_stack_is_empty()
        {
            Stack<string> stack = new Stack<string>(0);
            stack.Pop();
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void call_exception_if_do_TOP_empty_stack()
        {
            Stack<string> stack = new Stack<string>(0);
            stack.Top();
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void exception_if_MaxSize_stack_less_Null()
        {
            Stack<string> stack = new Stack<string>(-1);
        }
    }
}
