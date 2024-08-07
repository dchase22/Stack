using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example client usage of stack.
            Stack myStack = new Stack();
            for (int i = 1; i <= 10; i++)
            {
                myStack.push(i);
            }
            Console.WriteLine(myStack);
            var size = myStack.size();
            Console.WriteLine($"Stack Size: {size}");
            var element = myStack.pop();
            Console.WriteLine($"Popped element: {element}");
            var newSize = myStack.size();
            Console.WriteLine($"New Stack Size: {newSize}");
            Console.WriteLine(myStack);
        }
    }
}