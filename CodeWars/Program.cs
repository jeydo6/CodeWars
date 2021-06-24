using Newtonsoft.Json;
using System;

namespace CodeWars
{
	class Program
	{
		static void Main()
		{
			var json = JsonConvert.SerializeObject(
				LastDigitOfHugeNumber.Kata.LastDigit(new int[] { 82242, 254719, 736371 })
			);
			Console.WriteLine(json);
		}
	}
}
