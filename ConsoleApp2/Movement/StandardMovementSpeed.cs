using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Movement
{
	public class StandardMovementSpeed : IMovementSpeed
	{
		public int MoveMillisecondsPerFloor()
		{
			return 1;
		}
	}
}
