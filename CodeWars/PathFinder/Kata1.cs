using System.Linq;
using System.Numerics;

namespace CodeWars.PathFinder
{
	public class Kata1
	{
		public static bool PathFinder(string maze)
		{
			return PathFinder(maze
				.Split('\n')
				.Select(line => line.Select(ch => '.' - ch).ToArray())
				.ToArray()
			);
		}

		private static bool PathFinder(int[][] maze, int x = 0, int y = 0)
		{
			return
				x >= 0 && x < maze[0].Length &&
				y >= 0 && y < maze.Length &&
				(maze[y][x] == 0) &&
				(
					(x + 1 == maze[0].Length && y + 1 == maze.Length) ||
					(maze[y][x] = -1) == -1 &&
					(
						PathFinder(maze, x + 1, y) ||
						PathFinder(maze, x - 1, y) ||
						PathFinder(maze, x, y + 1) ||
						PathFinder(maze, x, y - 1)
					)
				);
		}

		public static BigInteger fib(int n)
		{
			BigInteger t;
			BigInteger s = 1;
			BigInteger i = 1;
			BigInteger j = 0;
			BigInteger k = 0;
			BigInteger h = 1;

			if (n < 0)
			{
				n *= -1;
				s = n % 2 == 0 ? -1 : 1;
			}

			while (n > 0)
			{

				if (n % 2 != 0)
				{
					t = j * h;
					j = i * h + j * k + t;
					i = i * k + t;
				}
				t = h * h;
				h = 2 * k * h + t;
				k = k * k + t;
				n /= 2;
			}

			return j * s;
		}
	}
}
