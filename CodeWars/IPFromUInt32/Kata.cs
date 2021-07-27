using System;
using System.Linq;

namespace CodeWars.IPFromUInt32
{
	public class Kata
	{
		public static string UInt32ToIP(uint ip)
		{
			return string.Join(".", Enumerable
				.Range(0, 4)
				.Select(i => Convert.ToInt32(
					(new string('0', 32) + Convert.ToString(ip, 2))[^32..][(8 * i)..(8 * i + 8)], 2)
				)
			);
		}
	}
}
