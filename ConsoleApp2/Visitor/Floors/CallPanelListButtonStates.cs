using System.Collections.Generic;
using ConsoleApp2.Button;
using ConsoleApp2.Floors;
using ConsoleApp2.Visitor.Floor;

namespace ConsoleApp2.Visitor.Floors 
{
	public class CallPanelListButtonStates : IFloorListVisitor, IFloorVisitor
	{
		public IList<int> EngagedUpButtons { get; } = new List<int>();
		public IList<int> EngagedDownButtons { get; } = new List<int>();

		public void Visit(IFloorList floorList)
		{
			//var floors = floorList.CopyFloors();
			foreach (var floor in floorList.Floors)
			{
				floor.Accept(this);
			}
		}

		public void Visit(IFloor floor)
		{
			if (floor.Panel == null)
			{
				return;
			}

			if (floor.Panel.Up.State == ButtonState.Engaged)
			{
				EngagedUpButtons.Add(floor.Identifier);
			}

			if (floor.Panel.Down.State == ButtonState.Engaged)
			{
				EngagedDownButtons.Add(floor.Identifier);
			}
		}
	}
}
