using System;

namespace CodeWars.LastDigitOfHugeNumber
{
	public class Kata
	{
		public static int LastDigit(int[] array)
		{
			var result = 1;
			for (var i = array.Length - 1; i >= 0; i--)
			{
				result = (int)Math.Pow(
					array[i] % 100,
					result < 4 ? result : result % 4 + 4
				);
			}
			return result % 10;
		}
	}
}
