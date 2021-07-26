using System.Linq;

namespace CodeWars.SimpleEncryption
{
	public class Kata1
	{
		public static string Encrypt(string text, int n)
		{
			if (string.IsNullOrEmpty(text) || n <= 0)
			{
				return text;
			}

			for (var i = 0; i < n; i++)
			{
				text = string.Concat(
					Enumerable.Concat(
						text.Where((ch, j) => j % 2 == 1), text.Where((ch, j) => j % 2 == 0)
					)
				);
			}

			return text;
		}

		public static string Decrypt(string text, int n)
		{
			if (string.IsNullOrEmpty(text) || n <= 0)
			{
				return text;
			}

			for (var i = 0; i < n; i++)
			{
				var left = text[..(text.Length / 2)];
				var right = text[(text.Length / 2)..];

				text = string.Concat(
					Enumerable.Range(0, text.Length)
						.Select(j => j % 2 == 0 ? right[j / 2] : left[j / 2])
				);
			}

			return text;
		}
	}
}
