using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Visitor;
using ConsoleApp2.Visitor.Floors;

namespace ConsoleApp2.Floors
{
	public class FloorList : IFloorList
	{
		//TODO: Exposes internal list, can make it an IList
		public IList<IFloor> Floors { get; }
		private IFloorListBuilder Builder { get; }

		public FloorList(IFloorListBuilder builder, int numberOfFloors)
		{
			Builder = builder;
			Floors = builder.BuildFloors(numberOfFloors);
		}

		public void Accept(IFloorListVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public interface IFloorList : IFloorListVisitable
	{
		IList<IFloor> Floors {get;}
	}
}
