using System;

// Chair
interface IChair
{
	void Create();
}

public class PlasticChair : IChair
{
	public void Create()
    {
		Console.WriteLine("Create plastic chair");

	}
}

public class WoodChair : IChair
{
	public void Create()
	{
		Console.WriteLine("Create wood chair");

	}
}

public class Class1
{
	public Class1()
	{
	}
}
