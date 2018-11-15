namespace ConsoleApp2.Button
{
	public class FloorButton : Button
	{
		public FloorButton(int floorNumber) : base(floorNumber.ToString()) { }

		public FloorButton(IButton button) : base(button) { }
	}
}
