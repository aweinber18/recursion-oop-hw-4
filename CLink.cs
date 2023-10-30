using System;

public class CLink<T>
{
	private T Value { get; set; }
	public CLink<T> Next { get; set; }
	public CLink()
	{

	}
	public CLink(T val)
	{
		Value = val;
	}

}
