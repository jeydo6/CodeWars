namespace CodeWars.VasyaClerk
{
	public class Kata
	{
		public static string Tickets(int[] peopleInLine)
		{
			var m25 = 0;
			var m50 = 0;

			foreach (var people in peopleInLine)
			{
				switch (people)
				{
					case 25:
						m25++;
						break;
					case 50:
						m25--;
						m50++;
						break;
					case 100:
						if (m50 == 0)
						{
							m25 -= 3;
						}
						else
						{
							m25--;
							m50--;
						}
						break;
				}

				if (m25 < 0 || m50 < 0)
				{
					return "NO";
				}
			}

			return "YES";
		}
	}
}
