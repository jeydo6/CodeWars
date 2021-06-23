using System.Collections.Generic;

namespace CodeWars.Morse
{
	class MorseCode
	{
		private static readonly Dictionary<string, string> _dict = new Dictionary<string, string>
		{
			["...."] = "H",
			["."] = "E",
			["-.--"] = "Y",
			[".---"] = "J",
			["..-"] = "U",
			["-.."] = "D"
		};

		public static string Get(string key)
		{
			return _dict[key];
		}
	}
}
