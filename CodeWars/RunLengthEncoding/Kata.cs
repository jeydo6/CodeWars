using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars.RunLengthEncoding
{
	public class Kata
	{
		public static string Encode(string str)
		{
			var sb = new StringBuilder();
			var count = 1;
			_ = (str + " ")
				.Aggregate((x, y) =>
				{
					if (x == y)
					{
						count++;
					}
					else
					{
						if (count > 1)
						{
							sb.Append(count);
						}
						sb.Append(x);
						count = 1;
					}

					return y;
				});

			return sb.ToString();
		}

		public static string Decode(string str)
		{
			return string.Join("", Regex.Matches(str, @"(\d*)(\w?)")
				.Select(m => new string(
					c: m.Groups[2].Value[0],
					count: int.TryParse(m.Groups[1].Value, out var count) ? count : 0
				))
			);
		}
	}
}
