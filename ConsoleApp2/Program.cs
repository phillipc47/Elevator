using System;
using System.Collections;
using System.Collections.Generic;
using ConsoleApp2.Factory;
using ConsoleApp2.Floors;
using ConsoleApp2.Panel;
using ConsoleApp2.Visitor;
using ConsoleApp2.Visitor.Floor;
using ConsoleApp2.Visitor.Floors;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			var floorListBuilder = new FloorListBuilder(new FloorFactory());

			IFloorList floorList = new FloorList(floorListBuilder, 2);

			var floors = floorList.Floors;
			floors[0].Panel.Up.Press();
			floors[0].Panel.Down.Press();
			floors[1].Panel.Down.Press();

			var callPanelListButtonStates = new CallPanelListButtonStates();
			floorList.Accept(callPanelListButtonStates);

			Console.WriteLine( $"Engaged Down: {string.Join(", ", callPanelListButtonStates.EngagedDownButtons)}");
			Console.WriteLine( $"Engaged Up: {string.Join(", ", callPanelListButtonStates.EngagedUpButtons)}");

			ElevatorPanel elevatorPanel = new ElevatorPanel(35);
			elevatorPanel.FloorButtons[0].Press();
			elevatorPanel.FloorButtons[12].Press();
			elevatorPanel.FloorButtons[17].Press();
			elevatorPanel.FloorButtons[30].Press();

			Console.WriteLine($"SelectedFloors: {string.Join(", ", elevatorPanel.SelectedFloors())}");

			Console.ReadLine();
		}
	}
}
