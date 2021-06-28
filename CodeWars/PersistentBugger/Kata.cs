using System.Linq;

namespace CodeWars.PersistentBugger
{
	public class Kata
	{
		public static int Persistence(long n)
		{
			var result = 0;
			while (n > 9)
			{
				n = n
					.ToString()
					.Select(ch => ch - '0')
					.Aggregate((x, y) => x * y);
				result++;
			}
			return result;
		}
	}
}
