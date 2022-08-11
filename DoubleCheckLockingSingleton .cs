/*this method is better with ThreadSafeLazyInitializedSingleton method, double check null instance*/
using System;

public class DoubleCheckLockingSingleton
{
	private static readonly object Lock = new object();
	private static readonly object Unlock = new object();

	private static DoubleCheckLockingSingleton instance;
	private DoubleCheckLockingSingleton()
	{
	}

	public static DoubleCheckLockingSingleton Instance()
    {
		if (instance == null)
		{
			lock (Lock)
			{
				if (instance == null)
				{
					instance = new DoubleCheckLockingSingleton();
				}
			}
		}
		return instance;
    }
}
