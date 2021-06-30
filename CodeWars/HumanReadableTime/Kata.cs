using System.Collections.Generic;
using System.Linq;

namespace CodeWars.HumanReadableTime
{
	public class Kata
	{
		public static string GetReadableDateTime(int seconds)
		{
			if (seconds == 0)
			{
				return "now";
			}
			else
			{
				var yearSeconds = 365 * 24 * 60 * 60;
				var daySeconds = 24 * 60 * 60;
				var hourSeconds = 60 * 60;
				var minuteSeconds = 60;

				var dict = new Dictionary<string, int>();

				dict["year"] = seconds / yearSeconds;
				seconds %= yearSeconds;

				dict["day"] = seconds / daySeconds;
				seconds %= daySeconds;

				dict["hour"] = seconds / hourSeconds;
				seconds %= hourSeconds;

				dict["minute"] = seconds / minuteSeconds;
				seconds %= minuteSeconds;

				dict["second"] = seconds;

				var array = dict
					.Where(kvp => kvp.Value > 0)
					.Select(kvp => $"{kvp.Value} {kvp.Key}{(kvp.Value > 1 ? "s" : "")}")
					.ToArray();

				var result = array.Length == 1
					? array[0]
					: string.Join(", ", array[..^1]) + $" and {array[^1]}";

				return result;
			}
		}

		public static string GetReadableTime(int seconds)
		{
			var hourSeconds = 60 * 60;
			var minuteSeconds = 60;

			var hours = seconds / hourSeconds;
			seconds %= hourSeconds;

			var minutes = seconds / minuteSeconds;
			seconds %= minuteSeconds;

			var result = $"{hours:00}:{minutes:00}:{seconds:00}";

			return result;
		}

	}
}
