using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Movement;

namespace ConsoleApp2.Event.FloorChange
{
	public delegate void FloorChangeHandler(IMoveable moveable, FloorChangeEventArgs eventArgs);
}
