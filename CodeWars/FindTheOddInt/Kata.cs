using System.Linq;

namespace CodeWars.FindTheOddInt
{
	public class Kata
	{
		public static int Find(int[] seq)
		{
			return seq
				.GroupBy(i => i)
				.First(g => g.Count() % 2 != 0)
				.Key;
		}
	}
}
