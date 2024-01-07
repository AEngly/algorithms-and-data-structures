using System.Collections.Generic;

public class CustomStack<T>
{
    private List<T> _list = new List<T>();

    public void Push(T item)
    {
        _list.Add(item);
    }

    public T Pop()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException("The stack is empty");

        var item = _list[^1];
        _list.RemoveAt(_list.Count - 1);
        return item;
    }

    public T Peek()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException("The stack is empty");

        return _list[^1];
    }

    public int Count => _list.Count;
}
