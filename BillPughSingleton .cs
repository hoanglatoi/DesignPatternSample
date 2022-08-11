using System;

public class BillPughSingleton
{
	private BillPughSingleton()
	{
	}

	public static BillPughSingleton Instance()
    {
		return BillPughSingletonFactory.instance;

	}

	private static class BillPughSingletonFactory
    {
		private static BillPughSingleton instance = new BillPughSingleton();
    }
}
