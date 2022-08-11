/*is good for single-thread, when multi-thread is run in the same time, can be more than one instance is created*/

using System;

public class LazyInitializedSingleton
{
	private static LazyInitializedSingleton instance;

	private LazyInitializedSingleton()
	{
	}

	public static LazyInitializedSingleton Instance()
    {
		if (instance == null)
        {
			instance = new LazyInitializedSingleton();
        }
		return instance;
    }
}
