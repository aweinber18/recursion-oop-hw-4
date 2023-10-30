﻿using System;

public class Node<T> where T : IComparable<T>
{
    public T Value { get; set; }
    public Node<T> Left { get; set; } = null!;
    public Node<T> Right { get; set; } = null!;
    public Node() { }
    public Node(T value) => Value = value;

    public static Node<T> ArrayToTree(T[] array)
    {
        Node<T> head = new Node<T>(array[0]);
        for (int i = 1; i < array.Length; i++)
        {
            head.Add(array, i);
        }
        return head;
    }

    public bool Search(T value)
    {
        if (Left == null) return false;
        if (Right == null) return false;
        return value.Equals(Value) || Left.Search(value) || Right.Search(value);
    }
    public int Size()
    {
        return Size(0);
    }

    private int Size(int soFar)
    {
        if (Left == null) return 1;
        if (Right == null) return 1;
        return 1 + Right.Size(++soFar) + Left.Size(++soFar);
    }

    public void Add(T[] array, int index)
    {
        int level = (int) Math.Log2(index + 1);
        bool[] goRight = GetTraversialInstructions(index);
        Node<T> current = this;
        for (int i = 0; i < level - 1; i++)
        {
            if (goRight[i])
            {
                current = current.Right;
            }
            else
            {
                current = current.Left;
            }
        }
        if (goRight[level - 1])
        {
            current.Right = new Node<T>(array[index]);
        }
        else
        {
            current.Left = new Node<T>(array[index]);
        }
    }
    public T PeekRight()
    {
        return Right.Value;
    }
    public T PeekLeft()
    {
        return Left.Value;
    }

    public void SwapRight()
    {
        T tempData = Right.Value;
        Right.Value = Value;
        Value = tempData;
    }
    public void SwapLeft()
    {
        T tempData = Left.Value;
        Left.Value = Value;
        Value = tempData;
    }

    private bool[] GetTraversialInstructions(int index)
    {
        int level = (int)Math.Log2(index + 1);

        bool[] goRight = new bool[level];
        int changingIndex = index;
        for (int i = level - 1; i >= 0; i--)
        {
            if (changingIndex % 2 == 0)
            {
                goRight[i] = true;
                changingIndex = (changingIndex - 2) / 2;
            }
            else
            {
                goRight[i] = false;
                changingIndex = (changingIndex - 1) / 2;
            }
        }
        return goRight;
    }

    public Node<T> GetNodeAt(int index)
    {
        int level = (int)Math.Log2(index + 1);
        Node<T> current = this;
        bool[] goRight = GetTraversialInstructions(index);

        for (int i = 0; i < level; i++)
        {
            if (goRight[i])
            {
                current = current.Right;
            }
            else
            {
                current = current.Left;
            }
        }
        return current;
    }
}
