/*Use lock(synObject to ensures that only 1 thread can access the function Instance at a time)
 This method has the disadvantage that a lock will run very slowly and consume performance
 */
using System;

public class ThreadSafeLazyInitializedSingleton
{
	private static ThreadSafeLazyInitializedSingleton instance;
	private static readonly object synObject = new object();

	private ThreadSafeLazyInitializedSingleton()
	{
	}

	public static ThreadSafeLazyInitializedSingleton Instance()
    {
        lock (synObject)
        {
			if (instance == null)
			{
				instance = new ThreadSafeLazyInitializedSingleton();
			}
			return instance;
		}		
    }
}
