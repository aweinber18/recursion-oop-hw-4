using System;
using System.Drawing;
using System.Security;

public class CLinkedList<T>
{
	CLink<T> head;
	public CLinkedList()
	{
	}

	public void Add(T val)
	{
		if (head == null)
		{
			head = new CLink<T>(val);
			head.Next = head;
			return;
		}

		CLink<T> current = head;
		CLink<T> newLink = new CLink<T>(val);
        while (current.Next != head)
        {
            current = current.Next;
        }
		current.Next = newLink;

		current.Next.Next = head;

    }

	private int Size(CLink<T> link, int soFar)
	{
		if (head == null)
			return soFar;
		else if (link.Next == head)
		{
			return ++soFar;
		}
        else
			return Size(link.Next, ++soFar);
    }

	public int Size()
	{
		return Size(head, 0);
	}
}
