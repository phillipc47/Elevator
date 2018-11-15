namespace ConsoleApp2.Button
{
	public class CallButton : Button
	{
		public CallButton(string descriptor) : base(descriptor) { }

		public CallButton(IButton button) : base(button) {}
	}
}
