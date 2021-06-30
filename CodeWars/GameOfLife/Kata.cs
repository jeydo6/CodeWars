using System.Linq;

namespace CodeWars.GameOfLife
{
	public class Kata
	{
		public static int[,] GetGeneration(int[,] cells, int generation)
		{
			//var height = cells.GetUpperBound(0) + 1;
			//var width = cells.GetUpperBound(1) + 1;
			//var str = string.Join(", ", Enumerable
			//	.Range(0, height)
			//	.Select(i => string.Join(" ", Enumerable
			//			.Range(0, width)
			//			.Select(j => cells.GetValue(i, j))
			//		)
			//	)
			//);

			for (var g = 0; g < generation; g++)
			{
				cells = GetGeneration(cells);

				if (cells.Length == 0)
				{
					break;
				}
			}

			return cells;
		}

		private static int[,] GetGeneration(int[,] cells)
		{
			var height = cells.GetUpperBound(0) + 1;
			var width = cells.GetUpperBound(1) + 1;
			var extended = new int[height + 2, width + 2];

			for (var i = 0; i < height; i++)
			{
				for (var j = 0; j < width; j++)
				{
					extended[i + 1, j + 1] = cells[i, j];
				}
			}

			var clone = extended.Clone() as int[,];
			for (var i = 0; i < height + 2; i++)
			{
				for (var j = 0; j < width + 2; j++)
				{
					extended[i, j] = IsAlive(clone, i, j);
				}
			}

			return Crop(extended);
		}

		private static int IsAlive(int[,] cells, int i, int j)
		{
			var neighbours = new int[][]
			{
				new int[2] { i - 1, j - 1 },
				new int[2] { i - 1, j },
				new int[2] { i - 1, j + 1 },
				new int[2] { i, j - 1 },
				new int[2] { i, j + 1 },
				new int[2] { i + 1, j - 1 },
				new int[2] { i + 1, j },
				new int[2] { i + 1, j + 1 }
			};

			var height = cells.GetUpperBound(0) + 1;
			var width = cells.GetUpperBound(1) + 1;
			var neighboursCount = neighbours
				.Where(p =>
					p[0] >= 0 && p[0] <= height - 1 &&
					p[1] >= 0 && p[1] <= width - 1
				)
				.Count(p => cells[p[0], p[1]] == 1);

			if (cells[i, j] == 1)
			{
				if (neighboursCount < 2 || neighboursCount > 3)
				{
					return 0;
				}

				return 1;
			}
			else
			{
				if (neighboursCount == 3)
				{
					return 1;
				}

				return 0;
			}
		}

		private static int[,] Crop(int[,] cells)
		{
			var height = cells.GetUpperBound(0) + 1;
			var width = cells.GetUpperBound(1) + 1;

			var iMin = height - 1;
			var iMax = 0;
			var jMin = width - 1;
			var jMax = 0;
			for (var i = 0; i < height; i++)
			{
				for (var j = 0; j < width; j++)
				{
					if (cells[i, j] != 0)
					{
						if (i < iMin) iMin = i;
						if (i > iMax) iMax = i;
						if (j < jMin) jMin = j;
						if (j > jMax) jMax = j;
					}
				}
			}

			height = iMax - iMin + 1;
			width = jMax - jMin + 1;
			if (height <= 0 || width <= 1)
			{
				return new int[0, 0];
			}

			var result = new int[height, width];
			for (var i = 0; i < height; i++)
			{
				for (var j = 0; j < width; j++)
				{
					result[i, j] = cells[iMin + i, jMin + j];
				}
			}

			return result;
		}
	}
}
