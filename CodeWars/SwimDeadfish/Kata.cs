using System.Collections.Generic;

namespace CodeWars.SwimDeadfish
{
	public class Kata
	{
		public static int[] Parse(string data)
		{
			var value = 0;
			var result = new List<int>();
			foreach (var command in data)
			{
				switch (command)
				{
					case 'i':
						value++;
						break;
					case 'd':
						value--;
						break;
					case 's':
						value *= value;
						break;
					case 'o':
						result.Add(value);
						break;
				}
			}
			return result.ToArray();
		}
	}
}
