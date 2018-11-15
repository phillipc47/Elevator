using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Factory
{
	public interface IFactory<T>
	{
		T Create(string descriptor);
	}
}
