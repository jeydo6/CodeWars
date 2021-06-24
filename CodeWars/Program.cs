using Newtonsoft.Json;
using System;

namespace CodeWars
{
	class Program
	{
		static void Main()
		{
			var json = JsonConvert.SerializeObject(
				Permutations.Kata.SinglePermutations("abc")
			);
			Console.WriteLine(json);
		}
	}
}
