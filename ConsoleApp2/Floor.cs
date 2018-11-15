using ConsoleApp2.Panel;
using ConsoleApp2.Visitor.Floor;

namespace ConsoleApp2
{
	public class Floor : IFloor
	{
		public CallPanel Panel { get; }
		public int  Identifier { get; }

		public Floor(int floorNumber, CallPanel panel)
		{
			Panel = panel;
			Identifier = floorNumber;
		}

		public Floor(IFloor floor)
		{
			Panel = new CallPanel(floor.Panel);
			Identifier = floor.Identifier;
		}

		public void Accept(IFloorVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public interface IFloor : IFloorVisitable
	{
		CallPanel Panel { get; }
		int Identifier { get; }
	}
}
