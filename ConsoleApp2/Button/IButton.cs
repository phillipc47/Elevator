namespace ConsoleApp2.Button
{
	public interface IButton
	{
		ButtonState State { get; }
		string Descriptor { get; set; }
		void Press(); 
	}
}
