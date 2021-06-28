using System.Collections.Generic;

namespace CodeWars.DirectionsReduction
{
	public class Kata
	{
		public static string[] DirReduc(string[] arr)
		{
			var result = new List<string>();

			for (var i = 0; i < arr.Length; i++)
			{
				if (result.Count > 0)
				{
					if (
						(arr[i] == "NORTH" && result[^1] == "SOUTH") ||
						(arr[i] == "SOUTH" && result[^1] == "NORTH") ||
						(arr[i] == "WEST" && result[^1] == "EAST") ||
						(arr[i] == "EAST" && result[^1] == "WEST")
					)
					{
						result.RemoveAt(result.Count - 1);
					}
					else
					{
						result.Add(arr[i]);
					}
				}
				else
				{
					result.Add(arr[i]);
				}
			}

			return result.ToArray();
		}
	}
}
