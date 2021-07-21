using System.Linq;

namespace CodeWars.WeirdStringCase
{
	public class Kata
	{
		public static string ToWeirdCase(string s)
		{
			return string.Join(" ", s
				.Split(" ")
				.Select(w => string.Join("", w
						.Select((ch, i) => i % 2 == 0 ? char.ToUpper(ch) : char.ToLower(ch))
					)
				)
			);
		}
	}
}
