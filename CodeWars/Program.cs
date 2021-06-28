using Newtonsoft.Json;
using System;

namespace CodeWars
{
	class Program
	{
		static void Main()
		{
			var json = JsonConvert.SerializeObject(
				PersistentBugger.Kata.Persistence(999)
			);
			Console.WriteLine(json);
		}
	}
}
