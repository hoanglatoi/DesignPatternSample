using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*is good for single-thread, when multi-thread is run in the same time, can be more than one instance is created*/

namespace DesignPattern.SingletonPattern
{
	public class LazyInitializedSingleton
	{
		private static LazyInitializedSingleton? instance = null;

		private LazyInitializedSingleton()
		{
		}

		public static LazyInitializedSingleton Instance()
		{
			if (instance == null)
			{
				Console.WriteLine("LazyInitializedSingleton instance is created");
				instance = new LazyInitializedSingleton();				
			}
			Console.WriteLine("LazyInitializedSingleton instance was created");
			return instance;
		}
	}
}
