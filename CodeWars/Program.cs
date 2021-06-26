using Newtonsoft.Json;
using System;

namespace CodeWars
{
	class Program
	{
		static void Main()
		{
			var json = JsonConvert.SerializeObject(
				RangeExtraction.Kata.Extract(new[] { 1, 2 })
			);
			Console.WriteLine(json);
		}
	}
}
