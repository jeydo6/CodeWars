using Newtonsoft.Json;
using System;

namespace CodeWars
{
	class Program
	{
		static void Main()
		{
			var json = JsonConvert.SerializeObject(
				DirectionsReduction.Kata.DirReduc(new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" })
			);
			Console.WriteLine(json);
		}
	}
}
