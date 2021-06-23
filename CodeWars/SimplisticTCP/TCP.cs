using System;
using System.Collections.Generic;

namespace CodeWars.SimplisticTCP
{
	public class TCP
	{
		private static readonly Dictionary<string, (string From, string To)[]> _edges = new Dictionary<string, (string From, string To)[]>
		{
			["APP_PASSIVE_OPEN"] = new[] { ("CLOSED", "LISTEN") },
			["APP_ACTIVE_OPEN"] = new[] { ("CLOSED", "SYN_SENT") },
			["APP_SEND"] = new[] { ("LISTEN", "SYN_SENT") },
			["APP_CLOSE"] = new[] { ("LISTEN", "CLOSED"), ("SYN_RCVD", "FIN_WAIT_1"), ("SYN_SENT", "CLOSED"), ("ESTABLISHED", "FIN_WAIT_1"), ("CLOSE_WAIT", "LAST_ACK") },
			["APP_TIMEOUT"] = new[] { ("TIME_WAIT", "CLOSED") },
			["RCV_SYN"] = new[] { ("LISTEN", "SYN_RCVD"), ("SYN_SENT", "SYN_RCVD") },
			["RCV_ACK"] = new[] { ("SYN_RCVD", "ESTABLISHED"), ("FIN_WAIT_1", "FIN_WAIT_2"), ("CLOSING", "TIME_WAIT"), ("LAST_ACK", "CLOSED") },
			["RCV_SYN_ACK"] = new[] { ("SYN_SENT", "ESTABLISHED") },
			["RCV_FIN"] = new[] { ("ESTABLISHED", "CLOSE_WAIT"), ("FIN_WAIT_1", "CLOSING"), ("FIN_WAIT_2", "TIME_WAIT") },
			["RCV_FIN_ACK"] = new[] { ("FIN_WAIT_1", "TIME_WAIT") }
		};

		public static string TraverseStates(string[] events)
		{
			var state = "CLOSED";

			foreach (var item in events)
			{
				if (_edges.ContainsKey(item))
				{
					var vertex = Array.Find(_edges[item], v => v.From == state);
					if (vertex != default)
					{
						state = vertex.To;
					}
					else
					{
						return "ERROR";
					}
				}
				else
				{
					return "ERROR";
				}
			}

			return state;
		}
	}
}
