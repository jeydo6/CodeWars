using Newtonsoft.Json;
using System;

namespace CodeWars
{
	class Program
	{
		static void Main()
		{
			var json = JsonConvert.SerializeObject(
				IPFromUInt32.Kata.UInt32ToIP(2149583361)
			);
			Console.WriteLine(json);
		}
	}
}
