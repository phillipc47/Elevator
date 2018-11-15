using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Button;

namespace ConsoleApp2.Visitor.Button
{
	public interface IButtonVisitor
	{
		void Visit(IButton button);

	}
}
