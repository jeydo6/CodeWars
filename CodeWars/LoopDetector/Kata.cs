using System.Collections.Generic;

namespace CodeWars.LoopDetector
{
	public class Kata
	{
		public static int GetLoopSize(Node startNode)
		{
			var dictionary = new Dictionary<Node, int>();

			var index = 0;
			while (startNode.Next != null)
			{
				if (dictionary.ContainsKey(startNode))
				{
					return index - dictionary[startNode];
				}

				dictionary[startNode] = index++;
				startNode = startNode.Next;
			}

			return 0;
		}
	}
}

