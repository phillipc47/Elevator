using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp2.Builder.ListBuilder;
using ConsoleApp2.Factory;
using ConsoleApp2.Panel;

namespace ConsoleApp2
{
	public class FloorListBuilder : IFloorListBuilder
	{
		//private List<IFloor> CreateFloors(int numberOfFloors)
		//{
		//	return numberOfFloors <= 0 ? new List<IFloor>(0) : new List<IFloor>(numberOfFloors);
		//}

		//public IList<IFloor> BuildFloors(int numberOfFloors)
		//{
		//	var floors = CreateFloors(numberOfFloors);

		//	for (int floorIndex = 0; floorIndex < numberOfFloors; floorIndex++)
		//	{
		//		floors.Add(new Floor(floorIndex + 1, new CallPanel()));
		//	}

		//	return floors;
		//}

		//public IList<IFloor> BuildFloors(IList<IFloor> source)
		//{
		//	var floors = CreateFloors(source.Count);
		//	floors.AddRange(source.Select(floor => new Floor(floor)).Cast<IFloor>());

		//	return floors;
		//}

		private IListBuilder<IFloor> ListBuilder { get; }

		public FloorListBuilder(IFactory<IFloor> floorFactory) : this(new ListBuilder<IFloor>(floorFactory))
		{
		}

		public FloorListBuilder(IListBuilder<IFloor> listBuilder)
		{
			ListBuilder = listBuilder;
		}

		public IList<IFloor> BuildFloors(int numberOfFloors)
		{
			return ListBuilder.BuildList(numberOfFloors);
		}
	}

	public interface IFloorListBuilder
	{
		IList<IFloor> BuildFloors(int numberOfFloors);
	}
}
