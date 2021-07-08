using Newtonsoft.Json;
using System;

namespace CodeWars
{
	class Program
	{
		static void Main()
		{
			var json = JsonConvert.SerializeObject(
				PathFinder.Kata1.PathFinder(".W.\n" +
				   ".W.\n" +
				   "...")
			);
			Console.WriteLine(json);
		}
	}
}
