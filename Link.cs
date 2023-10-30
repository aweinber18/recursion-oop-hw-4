using System;

public class Link<T>
{
    private T Value { get; set; }
    private Link<T> Next { get; set; }

    public Link() { }

    public Link(T data)
    {
		Value = data;
    }
    public void Add(T data)
    {
        Link<T> current = this;
        if (Value == null)
            Value = data;
        else
        {
            while (current.Next != null)
                current = current.Next;
            current.Next = new Link<T>(data);

        }
    }
    public override string ToString()
    {
        if (Next == null) return Value.ToString();
        return Value.ToString() + ", " + Next.ToString();
    }
}
