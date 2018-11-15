using ConsoleApp2.Movement;

namespace ConsoleApp2.Event.FloorChange
{
	public class FloorChangeListener
	{
		public void Subscribe(IMoveable moveable)
		{
			moveable.FloorChange += HandleIt;
		}

		public void HandleIt(IMoveable moveable, FloorChangeEventArgs eventArgs)
		{
			System.Console.WriteLine($"Got a floor change event, Elevator [{moveable.Identifier}] moving from {eventArgs.PreviousFloor} to {eventArgs.NewFloor}");
		}
	}
}
