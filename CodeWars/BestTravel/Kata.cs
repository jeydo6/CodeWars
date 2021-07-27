using System.Collections.Generic;
using System.Linq;

namespace CodeWars.BestTravel
{
	public class Kata
	{
		public static int? ChooseBestSum(int distance, int count, List<int> towns)
		{
			var temp = towns.Where(d => d <= distance);

			return temp.Any() ?
				temp
					.Select((d, i) => d + (count > 1 ?
							ChooseBestSum(distance - d, count - 1, temp.Skip(i + 1).ToList()) : 0
						)
					)
					.Max() :
				null;
		}
	}
}
