using System;

namespace ConsoleApp2.Event
{
	public class FloorChangeEventArgs : EventArgs
	{
		public int PreviousFloor { get; }
		public int NewFloor { get; }

		public FloorChangeEventArgs(int previousFloor, int newFloor)
		{
			PreviousFloor = previousFloor;
			NewFloor = newFloor;
		}
	}
}
