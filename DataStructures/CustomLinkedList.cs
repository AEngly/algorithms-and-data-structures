using System.Collections.Generic;

namespace Implementations;

// Terminology:

// Abstract data structure: A data structure that is defined by its behavior (interface) rather than its implementation.
// Concrete data structure: A data structure that is defined by its implementation.
// Dynamic data structure: A data structure that can grow and shrink during execution.
// Static data structure: A data structure that is fixed in size.

// Notes:

// CustomLinkedList<T> implements a doubly-linked list.
// Access modifiers (public, private, protected, internal, protected internal) are used to restrict or allow access to the members of a class.
// A linked list is a dynamic data structure that can grow and shrink during execution.
// This still requires some work.

public class CustomLinkedList<T>
{

    // Create a node class here
    public class Node
    {
        // Declare variables with [PRIVACY] [DATATYPE] [NAME]
        public Node? prev; // ? makes the reference type nullable (see version C# 8.0)
        public Node? next;
        public T? key;

        // Give me a constructor
        public Node(T key)
        {
            this.next = null;
            this.prev = null;
            this.key = key;
        }

        // Give me an empty constructor
        public Node()
        {
            this.next = null;
            this.prev = null;
            this.key = default(T);
        }

    }

    // Declare variables with [PRIVACY] [DATATYPE] [NAME]
    public int count;
    public Node? head;

    // Create a constructor
    public CustomLinkedList()
    {
        head = null;
        count = 0;
    }

    // Insertion: Time Complexity (Theta(1))
    public void Insert(T key)
    {
        // Create a new node
        Node newNode = new Node(key);

        // If the list is empty, then make the new node the head
        if (this.head == null)
        {
            this.head = newNode;
        }
        // Otherwise, insert the new node at the head
        else
        {
            newNode.next = this.head;
            this.head.prev = newNode;
            this.head = newNode;
        }

        // Increment the count
        this.count++;
    }

    // Search: Time Complexity (Theta(N))
    private Node Search(T key)
    {
        // Start at the head
        Node? current = this.head;

        // Traverse the list
        while (current != null)
        {
            // If the key is found, return true
            if (current.key.Equals(key))
            {
                return current;
            }

            // Otherwise, keep traversing
            current = current.next;
        }

        // If the key is not found, return false
        Node? emptyNode = null;
        return emptyNode;
    }

    // Delete: Time Complexity (Theta(N))
    public bool Delete(T key)
    {

        // Search for key
        Node target = this.Search(key);

        // If the key is found, delete it
        if (target.key != null && target.key.Equals(key))
        {
            // If the node is the head
            if (target.prev == null && target.next == null)
            {
                this.head = null;
            }
            else if (target.prev == null)
            {
                this.head = target.next;
                target.next.prev = null;
            }
            // If the node is the tail
            else if (target.next == null)
            {
                target.prev.next = null;
            }
            // If the node is in the middle
            else
            {
                target.prev.next = target.next;
                target.next.prev = target.prev;
            }
            // Decrement the count
            this.count--;
            // Return true
            return true;
        } // If the key is not found, return false
        else
        {
            return false;
        }
    }

    public bool IsEmpty() => count == 0;

}