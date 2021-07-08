using System.Linq;

namespace CodeWars.AreTheySame
{
	public class Kata
	{
		public static bool Comp(int[] a, int[] b)
		{
			if (a == null && b == null)
			{
				return true;
			}
			else if ((a == null && b != null) || (a != null && b == null))
			{
				return false;
			}
			else
			{
				return Enumerable.SequenceEqual(
					a.Select(n => n * n).OrderBy(n => n),
					b.OrderBy(n => n)
				);
			}
		}
	}
}
