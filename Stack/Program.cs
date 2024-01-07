using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create an instance of the built-in Stack
        var builtInStack = new Stack<string>();
        // Create an instance of your custom Stack
        var customStack = new CustomStack<string>();

        // Push elements onto both stacks
        foreach (var number in new[] { "One", "Two", "Three" })
        {
            builtInStack.Push(number);
            customStack.Push(number);
        }

        Console.WriteLine("Popping elements from the built-in Stack:");
        while (builtInStack.Count > 0)
        {
            Console.WriteLine(builtInStack.Pop());
        }

        Console.WriteLine("\nPopping elements from the custom Stack:");
        while (customStack.Count > 0)
        {
            Console.WriteLine(customStack.Pop());
        }
    }
}
