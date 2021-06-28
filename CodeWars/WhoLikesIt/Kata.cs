namespace CodeWars.WhoLikesIt
{
	public class Kata
	{
		public static string Likes(string[] names)
		{
			if (names.Length == 0)
			{
				return "no one likes this";
			}
			else if (names.Length == 1)
			{
				return $"{names[0]} likes this";
			}
			else if (names.Length == 2)
			{
				return $"{names[0]} and {names[1]} like this";
			}
			else if (names.Length == 3)
			{
				return $"{names[0]}, {names[1]} and {names[2]} like this";
			}
			else if (names.Length > 3)
			{
				return $"{names[0]}, {names[1]} and {names[2..].Length} others like this";
			}

			return null;
		}
	}
}
