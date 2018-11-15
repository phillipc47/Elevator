namespace ConsoleApp2.Visitor.Floors
{
	public interface IFloorListVisitable
	{
		void Accept(IFloorListVisitor visitor);
	}
}
