using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars.CountSmileys
{
	public class Kata
	{
		public static int CountSmileys1(string[] smileys)
		{
			var valid = new string[]
			{
				":)",
				":D",
				":-)",
				":-D",
				":~)",
				":~D",
				";)",
				";D",
				";-)",
				";-D",
				";~)",
				";~D"
			};

			return smileys.Count(s => valid.Contains(s));
		}

		public static int CountSmileys2(string[] smileys)
		{
			return smileys.Count(s => Regex.IsMatch(s, @"^[:;]{1}[~-]{0,1}[\)D]{1}$"));
		}
	}
}
