using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Factory;

namespace ConsoleApp2.Builder.ListBuilder
{
	public class ListBuilder<T> : IListBuilder<T>
	{
		private IFactory<T> Factory { get; }

		private List<T> CreateInitialList(int numberOfElements)
		{
			return numberOfElements <= 0 ? new List<T>(0) : new List<T>(numberOfElements);
		}

		public ListBuilder(IFactory<T> factory)
		{
			Factory = factory;
		}

		public IList<T> BuildList(int numberOfElements)
		{
			var list = CreateInitialList(numberOfElements);

			for (int index = 0; index < numberOfElements; index++)
			{
				list.Add(Factory.Create(index.ToString()));
			}

			return list;
		}
	}
}
