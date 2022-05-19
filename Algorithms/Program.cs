using Algorithms;
using Algorithms.Lib;
using Algorithms.Lib.Stacks;

var stack = new ArrayStack<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);

Console.WriteLine($"Should print out 4: {stack.Peek()}");

stack.Pop();

Console.WriteLine($"Should print out 3: {stack.Peek()}");

foreach (var item in stack)
{
    Console.WriteLine(item);
}