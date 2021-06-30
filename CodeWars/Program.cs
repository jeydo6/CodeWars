using Newtonsoft.Json;
using System;

namespace CodeWars
{
	class Program
	{
		static void Main()
		{
			var json = JsonConvert.SerializeObject(
				//GameOfLife.Kata.GetGeneration(new int[,] { { 1, 0, 0 }, { 0, 1, 1 }, { 1, 1, 0 } }, 4)
				//GameOfLife.Kata.GetGeneration(new int[,] { }, 4)
				GameOfLife.Kata.GetGeneration(new int[,] { { 0, 0, 0, 1, 1, 1, 0, 1 }, { 0, 1, 1, 1, 1, 1, 1, 0 }, { 1, 0, 1, 1, 1, 0, 0, 0 } }, 4)
			);
			Console.WriteLine(json);
		}
	}
}
