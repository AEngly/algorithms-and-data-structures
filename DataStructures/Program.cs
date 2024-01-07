using System;
using System.Collections.Generic;
using Implementations;

class Program
{
    static void Main()
    {

        // Start by printing empty line
        Console.WriteLine("");

        // Create an instance of the built-in Stack
        var builtInQueue = new Queue<int>();

        // Create an instance of your custom Stack
        var customQueue = new StaticQueue<int>(50);

        // Create array with 200 random integers
        var random = new Random();
        var numbers = new int[200];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1000);
        }

        // Push elements onto both queues
        for (int i = 0; i < 40; i++)
        {
            builtInQueue.Enqueue(numbers[i]);
            customQueue.Enqueue(numbers[i]);
        }

        Console.WriteLine("Dequeueing elements from the built-in queue:");
        while (builtInQueue.Count > 0)
        {
            Console.WriteLine(builtInQueue.Dequeue());
        }

        Console.WriteLine("Dequeueing elements from the custom queue:");
        while (!customQueue.IsEmpty())
        {
            Console.WriteLine(customQueue.Dequeue());
        }

        // Repeat to check wrap around
        for (int i = 40; i < 80; i++)
        {
            builtInQueue.Enqueue(numbers[i]);
            customQueue.Enqueue(numbers[i]);
        }

        Console.WriteLine("Dequeueing elements from the custom queue:");
        while (!customQueue.IsEmpty() || builtInQueue.Count > 0)
        {
            Console.WriteLine($"Built-in: {builtInQueue.Dequeue()}, Custom: {customQueue.Dequeue()}");
        }

        // Finish by printing empty line
            Console.WriteLine("");

    }
}
