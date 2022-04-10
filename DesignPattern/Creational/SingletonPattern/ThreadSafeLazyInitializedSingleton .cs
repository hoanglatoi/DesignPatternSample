using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Use lock(synObject to ensures that only 1 thread can access the function Instance at a time)
 This method has the disadvantage that a lock will run very slowly and consume performance
 */

namespace DesignPattern.SingletonPattern
{
	public class ThreadSafeLazyInitializedSingleton
	{
		private static ThreadSafeLazyInitializedSingleton? instance = null;
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
					Console.WriteLine("ThreadSafeLazyInitializedSingleton instance is created");
					instance = new ThreadSafeLazyInitializedSingleton();
				}
				Console.WriteLine("ThreadSafeLazyInitializedSingleton instance was created");
				return instance;
			}
		}
	}
}
