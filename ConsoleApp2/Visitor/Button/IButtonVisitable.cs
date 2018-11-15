using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Visitor.Button
{
	public interface IButtonVisitable
	{
		void Accept(IButtonVisitor visitor);
	}
}
