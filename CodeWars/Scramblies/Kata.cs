using System.Linq;

namespace CodeWars.Scramblies
{
	public class Kata
	{
		public static bool Scramble(string str1, string str2)
		{
			return str2.All(ch => str1.Count(ch1 => ch1 == ch) >= str2.Count(ch2 => ch2 == ch));
		}
	}
}
