using System.Collections.Generic;

namespace CodeWars.SortBinaryTree
{
	public class Kata
	{
		public static List<int> DepthFirstList(Node node)
		{
			var result = new List<int>();

			var queue = new Queue<Node>();
			if (node != null)
			{
				queue.Enqueue(node);
			}

			while (queue.Count > 0)
			{
				var item = queue.Dequeue();
				if (item != null)
				{
					result.Add(item.Value);

					queue.Enqueue(item.Left);
					queue.Enqueue(item.Right);
				}
			}

			return result;
		}

		public static List<int> BreadthFirstList(Node node)
		{
			var result = new List<int>();

			var stack = new Stack<Node>();
			if (node != null)
			{
				stack.Push(node);
			}

			while (stack.Count > 0)
			{
				var item = stack.Pop();
				if (item != null)
				{
					result.Add(item.Value);

					stack.Push(item.Left);
					stack.Push(item.Right);
				}
			}

			return result;
		}
	}
}
