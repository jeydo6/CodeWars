using System.Collections.Generic;

namespace CodeWars.TwiceLinear
{
	public class Kata
	{

		public static int DblLinear(int n)
		{
			var u = new List<int>
			{
				1
			};
			var yi = 0;
			var zi = 0;
			for (var i = 0; i < n; i++)
			{
				var y = 2 * u[yi] + 1;
				var z = 3 * u[zi] + 1;

				if (y <= z)
				{
					u.Add(y);
					yi++;

					if (y == z)
					{
						zi++;
					}
				}
				else
				{
					u.Add(z);
					zi++;
				}
			}

			return u[n];
		}
	}
}
