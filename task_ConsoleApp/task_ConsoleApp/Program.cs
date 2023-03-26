using PowerCollections;

PowerCollections.Stack<char> stack = new PowerCollections.Stack<char>();

Console.WriteLine(stack.Capacity);

stack.Push('a');
stack.Push('b');

Console.WriteLine(stack.Pop() + "/" + stack.Count);
