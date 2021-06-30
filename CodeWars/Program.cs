using Newtonsoft.Json;
using System;

namespace CodeWars
{
	class Program
	{
		static void Main()
		{
			var json = JsonConvert.SerializeObject(
				NarcissisticNumber.Kata.Narcissistic(153)
			);
			Console.WriteLine(json);
		}
	}
}
