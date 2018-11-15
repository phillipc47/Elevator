using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Visitor.Floor
{
	public interface IFloorVisitor
	{
		void Visit(IFloor floor);
	}
}
