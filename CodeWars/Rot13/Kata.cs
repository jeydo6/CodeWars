using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Rot13
{
	public class Kata
	{
		public static string Rot13(string message)
		{
			return string.Join("", message
				.Select(ch =>
				{
					if (char.IsLetter(ch))
					{
						var index = char.ToLower(ch) - 'a';
						var delta = (index + 13) % 26 - index;

						return (char)(ch + delta);
					}
					else
					{
						return ch;
					}
				})
			);
		}
	}
}
