using System.Collections.Generic;

namespace CodeWars.Josephus
{
	public class Kata
	{
		public static List<T> Permutation<T>(List<T> items, int k)
		{
			var result = new List<T>();

			var i = 0;
			while (items.Count > 0)
			{
				i = (i + k - 1) % items.Count;
				result.Add(items[i]);
				items.RemoveAt(i);
			}
			return result;
		}

		public static T Survivor<T>(List<T> items, int k)
		{
			var result = new List<T>();

			var i = 0;
			while (items.Count > 0)
			{
				i = (i + k - 1) % items.Count;
				result.Add(items[i]);
				items.RemoveAt(i);
			}
			return result[^1];
		}
	}
}
