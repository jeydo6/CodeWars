using System.Linq;

namespace CodeWars.TitleCase
{
	public class Kata
	{
		public static string TitleCase(string title, string minorWords = "")
		{
			if (title == null || title.Length == 0)
			{
				return "";
			}

			var minors = (minorWords ?? "")
				.ToLower()
				.Split(" ");

			var result = string.Join(" ", title
				.ToLower()
				.Split(" ")
				.Select(w => minors.Contains(w) ? w : $"{char.ToUpper(w[0])}{w[1..]}")
			);

			return $"{char.ToUpper(result[0])}{result[1..]}";
		}
	}
}
