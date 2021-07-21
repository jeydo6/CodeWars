using System.Linq;

namespace CodeWars.IPValidation
{
	public class Kata
	{
		public static bool IsValid(string ip)
		{
			var octets = ip.Split(".");

			return octets.Length == 4 && octets.All(o => int.TryParse(o, out var v)
				&& v.ToString() == o
				&& v >= 0
				&& v <= 255);
		}
	}
}
