using System.Linq;

namespace CodeWars.AlphabeticAnagrams
{
	public class Kata
	{
		public static long ListPosition(string str)
		{
			var array = str.ToCharArray();
			var sorted = array
				.OrderBy(ch => ch)
				.ToList();

			var unique = sorted
				.Distinct()
				.ToArray();

			var i = 0;
			var j = 0;

			var position = 1L;

			while (i < array.Length || j < unique.Length)
			{
				if (array[i] == unique[j++])
				{
					sorted
						.Remove(array[i]);

					unique = sorted
						.Distinct()
						.ToArray();

					i++;
					j = 0;
				}
				else
				{
					sorted.Remove(array[i] < unique[j - 1] ? array[i] : unique[j - 1]);

					var count = CountAnagrams(sorted.ToArray());
					position += count;
				}
			}

			return position;
		}

		private static long CountAnagrams(char[] word)
		{
			return Factorial(word.Length) / word
				.GroupBy(ch => ch)
				.Select(g => g.Count())
				.Aggregate(1L, (current, t) => current * Factorial(t));
		}

		private static long Factorial(int n)
		{
			return n == 0 ? 1 : Factorial(n - 1) * n;
		}
	}
}
