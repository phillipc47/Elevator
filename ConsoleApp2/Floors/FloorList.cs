using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Visitor;
using ConsoleApp2.Visitor.Floors;

namespace ConsoleApp2.Floors
{
	public class FloorList : IFloorList
	{
		//TODO: Exposes internal list
		public IList<IFloor> Floors { get; }

		public FloorList(IFloorListBuilder builder, int numberOfFloors)
		{
			Floors = builder.BuildFloors(numberOfFloors);
		}

		public void Accept(IFloorListVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public interface IFloorList : IFloorListVisitable
	{
		IList<IFloor> Floors { get; }
	}
}
