namespace CodeWars.BattleshipFieldValidator
{
	public class Kata
	{
		public static bool Validate(int[,] field, int x, int y)
		{
			return x < 0 || y < 0 || x > 10 || y > 10 || (field[x, y] == 0);
		}

		public static bool ValidateBattlefield(int[,] field)
		{
			var ships = new int[5];

			for (var x = 0; x < 10; x++)
			{
				int h = 0;
				int v = 0;

				for (var y = 0; y < 10; y++)
				{

					if (field[x, y] == 1 &&
						Validate(field, x - 1, y) &&
						Validate(field, x - 1, y + 1) &&
						Validate(field, x - 1, y - 1) &&
						Validate(field, x + 1, y) &&
						Validate(field, x + 1, y + 1) &&
						Validate(field, x + 1, y - 1)
					)
					{
						h++;
					}
					else
					{
						if (h > 4) return false;
						if (h != 0) ships[h]++;
						h = 0;
					}

					if (field[y, x] == 1 &&
						Validate(field, y, x - 1) &&
						Validate(field, y + 1, x - 1) &&
						Validate(field, y - 1, x - 1) &&
						Validate(field, y, x + 1) &&
						Validate(field, y + 1, x + 1) &&
						Validate(field, y - 1, x + 1)
					)
					{
						v++;
					}
					else
					{
						if (v > 4) return false;
						if (v != 0) ships[v]++;
						v = 0;
					}
				}
			}
			return
				ships[4] == 1 &&
				ships[3] == 2 &&
				ships[2] == 3 &&
				ships[1] == 4 * 2;
		}
	}
}