using Newtonsoft.Json;
using System;

namespace CodeWars
{
	class Program
	{
		static void Main()
		{
			var json = JsonConvert.SerializeObject(
				SimplisticTCP.TCP.TraverseStates(new[] { "APP_PASSIVE_OPEN", "RCV_SYN", "RCV_ACK", "APP_CLOSE", "APP_SEND" })
			);
			Console.WriteLine(json);
		}
	}
}
