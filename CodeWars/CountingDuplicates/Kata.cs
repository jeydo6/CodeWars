using System.Linq;

namespace CodeWars.CountingDuplicates
{
	public class Kata
	{
		public static int DuplicateCount(string str)
		{
			return str
				.ToLower()
				.GroupBy(ch => ch)
				.Count(g => g.Count() > 1);
		}
	}
}
