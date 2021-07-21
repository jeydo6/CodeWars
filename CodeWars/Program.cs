using Newtonsoft.Json;
using System;

namespace CodeWars
{
	class Program
	{
		static void Main()
		{
			var json = JsonConvert.SerializeObject(
				TortoiseRaicing.Kata.Race(720, 850, 70)
			);
			Console.WriteLine(json);
		}
	}
}
