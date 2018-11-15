namespace ConsoleApp2.Visitor.Floor
{
	public interface IFloorVisitable
	{
		void Accept(IFloorVisitor visitor);
	}
}
