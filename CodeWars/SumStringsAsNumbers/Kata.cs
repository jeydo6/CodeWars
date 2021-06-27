using System.Numerics;

namespace CodeWars.SumStringsAsNumbers
{
	public class Kata
	{
		public static string SumStrings(string a, string b)
		{
			_ = BigInteger.TryParse(a, out var aNum);
			_ = BigInteger.TryParse(b, out var bNum);

			return $"{aNum + bNum}";
		}
	}
}
