using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Button;
using ConsoleApp2.Visitor.Button;
using ConsoleApp2.Visitor.ButtonList;

namespace ConsoleApp2
{
	public class SelectedFloorsVisitor : IButtonListVisitor, IButtonVisitor
	{
		public IList<int> SelectedFloors { get; } = new List<int>();

		public void Visit(IList<IButton> buttonList)
		{
			foreach (var button in buttonList)
			{
				Visit(button);
			}
		}

		public void Visit(IButton button)
		{
			if (button.State == ButtonState.Engaged)
			{
				if (int.TryParse(button.Descriptor, out int floorNumber))
				{
					SelectedFloors.Add(floorNumber);
				}
			}
		}
	}
}
