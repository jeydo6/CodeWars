namespace CodeWars.PileOfCubes
{
	public class Kata
	{
		public static long FindNb(long m)
		{
			var sum = 0L;
			var i = 1L;
			while (sum < m)
			{
				sum += i * i * i;
				i++;
			}

			return sum == m ? i - 1 : -1;
		}
	}
}
