namespace CodeWars.ValidBraces
{
	public class Kata
	{
		public static bool ValidBraces(string braces)
		{
			string prev = "";
			while (braces.Length != prev.Length)
			{
				prev = braces;
				braces = braces
					.Replace("()", "")
					.Replace("[]", "")
					.Replace("{}", "");
			}
			return braces.Length == 0;
		}
	}
}
