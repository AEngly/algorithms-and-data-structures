using System.Collections.Generic;

namespace Implementations;

// Terminology:

// Abstract data structure: A data structure that is defined by its behavior (interface) rather than its implementation.
// Concrete data structure: A data structure that is defined by its implementation.
// Dynamic data structure: A data structure that can grow and shrink during execution.
// Static data structure: A data structure that is fixed in size.

// Notes:

// The built-in Stack<T> class is a concrete and static data structure.
// A stack follows the LIFO (Last In First Out) principle.
// Space complexity: Theta(N)

public class StaticStack<T>
{
    // Declare variables with [PRIVACY] [DATATYPE] [NAME]
    private int capacity;
    private T[] stack;
    private int top = -1;

    // Constructor
    public StaticStack(int capacity)
    {
        this.capacity = capacity;
        this.stack = new T[capacity];
    }

    // Implement method for Push
    // Runtime complexity: Theta(1)
    public void Push(T item)
    {

        // Check if stack is full
        if (this.top == this.capacity - 1)
            throw new StackOverflowException("The stack is full.");

        // Primary
        stack[++this.top] = item;

        // Alternative
        // top += 1;
        // stack[top] = item;
    }

    // Implement method for Pop
    // Runtime complexity: Theta(1)
    public T Pop()
    {
        if (this.IsEmpty())
            throw new InvalidOperationException("The stack is empty.");

        var item = stack[this.top--]; // Where X-- refers to a post-decrement operation
        return item;
    }


    // Implement method for Peek
    // Runtime complexity: Theta(1)
    public T Peek()
    {
        if (this.IsEmpty())
            throw new InvalidOperationException("The stack is empty.");

        return stack[this.top];
    }


    // Implement method for IsEmpty
    // Runtime complexity: Theta(1)
    public bool IsEmpty() => this.top == -1;

    // Implement method for Count
    // Runtime complexity: Theta(1)
    public int Count() => this.top + 1;
}
