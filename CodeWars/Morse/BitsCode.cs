using System.Collections.Generic;

namespace CodeWars.Morse
{
	class BitsCode
	{
		private static readonly Dictionary<string, string> _dict = new Dictionary<string, string>
		{
			["1"] = ".",
			["111"] = "-",
			["0"] = "",
			["000"] = " ",
			["0000000"] = "   "
		};

		public static void Set(string key, string value)
		{
			_dict[key] = value;
		}

		public static string Get(string key)
		{
			return _dict[key];
		}
	}
}
