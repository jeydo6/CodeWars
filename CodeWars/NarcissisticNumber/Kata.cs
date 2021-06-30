using System;
using System.Linq;

namespace CodeWars.NarcissisticNumber
{
	public class Kata
	{
		public static bool Narcissistic(int number)
		{
			var str = number.ToString();
			return str.Sum(ch => Math.Pow(Convert.ToInt16(ch.ToString()), str.Length)) == number;
		}

		//public static bool Narcissistic(int number)
		//{
		//	var power = 0;
		//	var temp = number;
		//	while (temp > 0)
		//	{
		//		power++;
		//		temp /= 10;
		//	}

		//	var sum = 0;
		//	temp = number;
		//	while (temp > 0)
		//	{
		//		sum += (int)Math.Pow(temp % 10, power);
		//		temp /= 10;
		//	}

		//	return sum == number;
		//}
	}
}
