using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Factory
{
	public class ValueFactory<T> : IFactory<T> where T : struct
	{
		public T Create(string descriptor = "")
		{
			if (typeof(T).IsValueType || typeof(T) == typeof(string))
			{
				return default(T);
			}

			throw new NotImplementedException();
		}
	}
}
