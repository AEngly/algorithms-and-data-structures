using System.Collections.Generic;

namespace Implementations;

// Terminology:

// Abstract data structure: A data structure that is defined by its behavior (interface) rather than its implementation.
// Concrete data structure: A data structure that is defined by its implementation.
// Dynamic data structure: A data structure that can grow and shrink during execution.
// Static data structure: A data structure that is fixed in size.

// Notes:

// The CustomQueue<T> class is a concrete and static data structure.
// A stack follows the FIFO (First In First Out) principle.

public class StaticQueue<T>
{
    // Declare variables with [PRIVACY] [DATATYPE] [NAME]
    private int capacity;
    private T[] queue;
    private int head = 0;
    private int tail = 0;
    private int count = 0;

    // Constructor
    public StaticQueue(int capacity)
    {
        this.capacity = capacity;
        this.queue = new T[capacity];
    }

    // Implement method for Push
    public void Enqueue(T item)
    {

        // Check if queue is full
        if (count == capacity)
            throw new StackOverflowException("The stack is full.");

        // Primary
        queue[tail++] = item;
        count++;

        // Wrap around
        if (tail >= capacity)
            tail %= capacity;

    }

    // Implement method for Pop
    public T Dequeue()
    {
        if (this.IsEmpty())
            throw new InvalidOperationException("The queue is empty.");

        // Get the right item and increment the head
        var item = queue[head++]; // Where X++ refers to a post-decrement operation
        count--;

        // Wrap around
        if (head >= capacity)
            head %= capacity;

        return item;
    }


    // Implement method for Peek
    public T Peek()
    {
        if (this.IsEmpty())
            throw new InvalidOperationException("The queue is empty.");

        return this.queue[this.head];
    }


    // Implement method for IsEmpty
    public bool IsEmpty() => this.count == 0;

    // Implement method for Count
    public int Count() => this.count;

}
