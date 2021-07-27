using System.Linq;

namespace CodeWars.GoodVsEvil
{
	public class Kata
	{
		private static readonly int[] _goodWorth = new int[] { 1, 2, 3, 3, 4, 10 };

		private static readonly int[] _evilWorth = new int[] { 1, 2, 2, 2, 3, 5, 10 };

		// "1 1 1 1 1 1", "1 1 1 1 1 1 1"
		public static string GoodVsEvil(string good, string evil)
		{
			var goodSum = good
				.Split(" ")
				.Select(ch => int.Parse(ch))
				.Zip(_goodWorth, (a, b) => a * b)
				.Sum();

			var evilSum = evil
				.Split(" ")
				.Select(ch => int.Parse(ch))
				.Zip(_evilWorth, (a, b) => a * b)
				.Sum();

			if (goodSum > evilSum)
			{
				return "Battle Result: Good triumphs over Evil";
			}
			else if (goodSum < evilSum)
			{
				return "Battle Result: Evil eradicates all trace of Good";
			}
			else
			{
				return "Battle Result: No victor on this battle field";
			}
		}
	}
}
