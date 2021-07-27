using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.FindMissingInProgression
{
	public class Kata
	{
		public static int FindMissing(List<int> list)
		{
			var step = (list[^1] - list[0]) / list.Count;

			for (var i = 0; i < list.Count - 1; i++)
			{
				if (list[i + 1] - list[i] != step)
				{
					return list[i] + step;
				}
			}

			return list[0];
		}
	}
}
