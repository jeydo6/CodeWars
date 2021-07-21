using System.Collections.Generic;

namespace CodeWars.ParseNumber
{
	public class Kata
	{

		private static Dictionary<string, int> _numbers = new Dictionary<string, int>
		{
			{"zero", 0 },
			{ "one", 1 },
			{ "two", 2 },
			{ "three", 3 },
			{ "four", 4 },
			{ "five", 5 },
			{ "six", 6 },
			{ "seven", 7 },
			{ "eight", 8 },
			{ "nine", 9 },
			{ "ten", 10 },
			{ "eleven", 11 },
			{ "twelve", 12 },
			{ "thirteen", 13 },
			{ "fourteen", 14  },
			{ "fifteen", 15 },
			{ "sixteen", 16},
			{ "seventeen", 17 },
			{ "eighteen", 18 },
			{ "nineteen", 19 },
			{ "twenty", 20 },
			{ "thirty", 30 },
			{ "forty", 40 },
			{ "fifty", 50 },
			{ "sixty", 60 },
			{ "seventy", 70 },
			{ "eighty", 80 },
			{ "ninety", 90 }
		};

		private static Dictionary<string, int> _multipliers = new Dictionary<string, int>
		{
			{ "hundred", 100 },
			{ "thousand", 1000 },
			{ "million", 1000000 }
		};

		public static int ParseInt(string s)
		{
			int result = 0;

			var multiplier = 1;
			var list = s
				.Replace(" and ", " ")
				.Replace("-", " ")
				.Split(' ');

			for (var i = list.Length - 1; i >= 0; i--)
			{
				if (_numbers.ContainsKey(list[i]))
				{
					result += _numbers[list[i]] * multiplier;
				}
				else if (_multipliers.ContainsKey(list[i]))
				{
					if (multiplier < _multipliers[list[i]])
					{
						multiplier = _multipliers[list[i]];
					}
					else
					{
						multiplier *= _multipliers[list[i]];
					}
				}
			}

			return result;
		}
	}
}
