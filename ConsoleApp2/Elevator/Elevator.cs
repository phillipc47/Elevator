using System;
using System.Threading;
using ConsoleApp2.Event;
using ConsoleApp2.Event.FloorChange;
using ConsoleApp2.Movement;
using ConsoleApp2.Panel;

namespace ConsoleApp2.Elevator
{
	public class Elevator : IElevator, IMoveable
	{
		public string Descriptor { get; }
		public string Identifier => Descriptor;

		public IElevatorPanel Panel { get; }
		public MovementState State { get; private set; }
		public ElevatorDirection CurrentDirection { get; private set; }
		public IMovementSpeed Speed { get; }

		public Elevator(string descriptor, int numberOfFloors) : this(descriptor, new ElevatorPanel(numberOfFloors), new StandardMovementSpeed())
		{
			Panel = new ElevatorPanel(numberOfFloors);
		}

		public Elevator(string descriptor, IElevatorPanel elevatorPanel, IMovementSpeed speed)
		{
			State = MovementState.Idle;
			CurrentDirection = ElevatorDirection.None;
			CurrentFloor = 0;
			Descriptor = descriptor;
			Panel = elevatorPanel;
			Speed = speed;
		}

		#region Moveable

		public event FloorChangeHandler FloorChange;

		private ElevatorDirection DetermineDirection(int desiredFloor)
		{
			if (desiredFloor > CurrentFloor)
			{
				return ElevatorDirection.Up;
			}

			if (desiredFloor < CurrentFloor)
			{
				return ElevatorDirection.Down;
			}

			return ElevatorDirection.None;
		}

		private void SimulateMovement()
		{
			Thread.Sleep(this.Speed.MoveMillisecondsPerFloor());
		}

		private void RaiseFloorChange(int previousFloor, int currentFloor)
		{
			//Console.WriteLine($"Floor is Changing from {previousFloor} to {currentFloor} and Floor change {(FloorChange == null ? "is" : "is not")} null");
			FloorChange?.Invoke(this, new FloorChangeEventArgs(previousFloor, currentFloor));
		}

		private delegate void Move(int desiredFloor);

		private void MoveUp(int desiredFloor)
		{
			Console.WriteLine("Moving Up");
			for (; CurrentFloor < desiredFloor; CurrentFloor++)
			{
				SimulateMovement();
				RaiseFloorChange(CurrentFloor, CurrentFloor + 1);
			}
		}

		private void MoveDown(int desiredFloor)
		{
			Console.WriteLine("Moving Down");
			for (; CurrentFloor > desiredFloor; CurrentFloor--)
			{
				SimulateMovement();
				RaiseFloorChange(CurrentFloor, CurrentFloor - 1);
			}
		}

		public int CurrentFloor { get; private set; }
		public void MoveTo(int desiredFloor)
		{
			//TODO: Lock
			CurrentDirection = DetermineDirection(desiredFloor);
			State = MovementState.Active;

			Move mover = CurrentDirection == ElevatorDirection.Down ? new Move(MoveDown) : MoveUp;
			mover(desiredFloor);

			State = MovementState.Idle;
			CurrentDirection = ElevatorDirection.None;
		}

		#endregion Moveable

	}

	public interface IElevator
	{
		string Descriptor { get; }
		int CurrentFloor { get; }
		IElevatorPanel Panel { get; }
		ElevatorDirection CurrentDirection { get; }
		IMovementSpeed Speed { get; }
	}
}
