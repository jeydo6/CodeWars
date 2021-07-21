using System;

namespace CodeWars.TortoiseRaicing
{
	public class Kata
	{
		public static int[] Race(int v1, int v2, int g)
		{
			if (v1 >= v2)
			{
				return null;
			}
			else
			{
				var t = TimeSpan.FromHours((double)g / (v2 - v1));

				return new int[3] { t.Hours, t.Minutes, t.Seconds };
			}
		}
	}
}
