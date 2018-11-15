using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Floors;

namespace ConsoleApp2.Visitor
{
	public interface IFloorListVisitor
	{
		void Visit(IFloorList floorList);

	}
}
