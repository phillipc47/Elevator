using System;
using System.Collections.Generic;
using ConsoleApp2.Button;

namespace ConsoleApp2.Visitor.ButtonList
{
	public interface IButtonListVisitor
	{
		void Visit(IList<IButton> buttonList);
	}
}
