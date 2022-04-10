using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*this method is better with ThreadSafeLazyInitializedSingleton method, double check null instance*/

namespace DesignPattern.SingletonPattern
{
	public class DoubleCheckLockingSingleton
	{
		private static readonly object Lock = new object();

		private static DoubleCheckLockingSingleton? instance = null;
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
						Console.WriteLine("DoubleCheckLockingSingleton instance is created");
						instance = new DoubleCheckLockingSingleton();
					}
				}
			}
			Console.WriteLine("DoubleCheckLockingSingleton instance was created");
			return instance;
		}
	}
}
