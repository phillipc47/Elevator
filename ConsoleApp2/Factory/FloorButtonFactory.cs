using ConsoleApp2.Button;

namespace ConsoleApp2.Factory
{
	public class FloorButtonFactory : IFactory<IButton>
	{
		public IButton Create(string descriptor)
		{
			return new FloorButton(int.Parse(descriptor));
		}
	}
}
