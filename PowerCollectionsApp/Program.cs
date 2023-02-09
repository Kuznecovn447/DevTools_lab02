using Wintellect.PowerCollections;

namespace PowerCollectionsApp
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>(100);
            stack.Push(100);
            stack.Clear();
            return;
        }
    }
}
