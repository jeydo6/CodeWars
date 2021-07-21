namespace CodeWars.SortBinaryTree
{
	public class Node
	{
		public Node(Node left, Node right, int value)
		{
			Left = left;
			Right = right;
			Value = value;
		}

		public Node Left { get; }

		public Node Right { get; }

		public int Value { get; }
	}
}
