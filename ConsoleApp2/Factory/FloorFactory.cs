using ConsoleApp2.Panel;

namespace ConsoleApp2.Factory
{
	public class FloorFactory : IFactory<IFloor>
	{
		private CallPanel Panel { get; }

		public FloorFactory()
		{
			Panel = new CallPanel();
		}

		public FloorFactory(CallPanel panel)
		{
			Panel = new CallPanel(panel);
		}

		public IFloor Create(string descriptor)
		{
			return new Floor(int.Parse(descriptor), new CallPanel(Panel));
		}
	}
}
