using ConsoleApp2.Button;

namespace ConsoleApp2.Panel
{
	public class CallPanel
	{
		public IButton Up { get; }
		public IButton Down { get; }

		public CallPanel()
		{
			Up = new CallButton("Up");
			Down = new CallButton("Down");
		}

		public CallPanel(CallPanel panel)
		{
			Up = new CallButton(panel.Up);
			Down = new CallButton(panel.Down);
		}
	}
}
