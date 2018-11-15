using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using ConsoleApp2.Builder.ListBuilder;
using ConsoleApp2.Button;
using ConsoleApp2.Factory;
using ConsoleApp2.Visitor.ButtonList;

namespace ConsoleApp2.Panel
{
	public class ElevatorPanel : Panel, IElevatorPanel
	{
		public IList<IButton> FloorButtons { get; }
		
		public ElevatorPanel(int numberOfFloors)
		{
			IFactory<IButton> floorButtonFactory = new FloorButtonFactory();
			IListBuilder<IButton> floorButtonListBuilder = new ListBuilder<IButton>(floorButtonFactory);

			FloorButtons = floorButtonListBuilder.BuildList(numberOfFloors);
		}

		public IList<int> SelectedFloors()
		{
			var visitor = new SelectedFloorsVisitor();
			visitor.Visit(FloorButtons);

			return visitor.SelectedFloors;
		}
	}

	public interface IElevatorPanel
	{
		IList<IButton> FloorButtons { get; }

		IList<int> SelectedFloors();
	}
}
