using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Panel;

namespace ConsoleApp2
{
	public class Elevator
	{
		public IElevatorPanel Panel { get; }

		public Elevator(int numberOfFloors) : this(new ElevatorPanel(numberOfFloors))
		{
			Panel = new ElevatorPanel(numberOfFloors);
		}

		public Elevator(IElevatorPanel elevatorPanel)
		{
			Panel = elevatorPanel;
		}

	}
}
