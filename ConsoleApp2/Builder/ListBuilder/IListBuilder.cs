using System.Collections.Generic;

namespace ConsoleApp2.Builder.ListBuilder
{
	public interface IListBuilder<T>
	{
		IList<T> BuildList(int numberOfElements);
	}
}
