using System.Linq;

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
	}
}
