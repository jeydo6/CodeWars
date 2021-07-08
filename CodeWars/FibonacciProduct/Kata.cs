namespace CodeWars.FibonacciProduct
{
	public class Kata
	{
		public static ulong[] ProductFib(ulong prod)
		{
			var f1 = 1UL;
			var f2 = 1UL;
			while (f1 * f2 < prod)
			{
				var temp = f1;
				f1 = f2;
				f2 += temp;
			}

			return new ulong[3] { f1, f2, f1 * f2 == prod ? 1UL : 0UL };
		}
	}
}
