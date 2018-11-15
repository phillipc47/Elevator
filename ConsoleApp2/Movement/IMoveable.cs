using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using ConsoleApp2.Elevator;
using ConsoleApp2.Event;
using ConsoleApp2.Event.FloorChange;

namespace ConsoleApp2.Movement
{
	public interface IMoveable
	{
		event FloorChangeHandler FloorChange;
		string Identifier { get; }
		int CurrentFloor { get; }
		void MoveTo( int desiredFloor );
		MovementState State { get; }
	}
}
