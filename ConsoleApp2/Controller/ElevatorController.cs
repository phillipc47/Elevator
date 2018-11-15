using System.Collections.Generic;
using ConsoleApp2.Elevator;
using ConsoleApp2.Event.FloorChange;
using ConsoleApp2.Movement;

namespace ConsoleApp2.Controller
{
	public class ElevatorController : IElevatorController
	{
		private IDictionary<string, IMoveable> Moveables { get; }
		private IList<FloorChangeListener> Listeners { get; }

		private IMoveable LookupMoveable(string identifier)
		{
			var elevator = Moveables[identifier];
			return elevator;
		}

		public ElevatorController()
		{
			Moveables = new Dictionary<string, IMoveable>();
			Listeners = new List<FloorChangeListener>();
		}

		public void AddMoveable(IMoveable moveable)
		{
			var listener = new FloorChangeListener();
			listener.Subscribe(moveable);
			Listeners.Add(listener);

			Moveables.Add(moveable.Identifier, moveable);
		}

		public void Move(string identifier, int desiredFloor)
		{
			var moveable = LookupMoveable(identifier);
			moveable.MoveTo(desiredFloor);
		}

		public MovementState DetermineElevatorState(string identifier)
		{
			var moveable = LookupMoveable(identifier);
			return moveable.State;
		}
	}

	public interface IElevatorController
	{
		void AddMoveable(IMoveable moveable);
		void Move(string identifier, int desiredFloor);
		MovementState DetermineElevatorState(string identifier);
	}
}
