using System;

class Stack<T>
{
    private T[] items;
    private int top;
    private int capacity;

    private bool IsEmpty() => top == -1;

    public Stack(int size)
    {
        items = new T[size];
        capacity = size;
        top = -1;
    }

    public void Push(T item)
    {
        if (top == capacity - 1)
        {
            Console.WriteLine("Stack overflow!");
            return;
        }
        items[++top] = item;
    }

    public T Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException("Stack underflow!");
        return items[top--];
    }

    public T Peek()
    {
        if (IsEmpty()) throw new InvalidOperationException("Stack is empty!");
        return items[top];
    }


}