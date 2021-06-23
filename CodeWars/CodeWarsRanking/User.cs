using System;
using System.Linq;

namespace CodeWars.CodeWarsRanking
{
	public class User
	{
		private static readonly int[] _ranks = new int[] { -8, -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8 };

		private int rankIndex = 0;

		public int rank
		{
			get
			{
				return _ranks[rankIndex];
			}
		}

		public int progress { get; private set; }

		//public void incProgress(int rank)
		//{
		//	if (!_ranks.Contains(rank))
		//	{
		//		throw new ArgumentException();
		//	}

		//	Console.WriteLine("user: " + this.rank);
		//	Console.WriteLine("task: " + rank);

		//	while (true)
		//	{
		//		var score = 0;

		//		var diff = rank - this.rank;
		//		if (diff > 0)
		//		{
		//			score = 10 * diff * diff;
		//		}
		//		else if (diff == 0)
		//		{
		//			score = 3;
		//		}
		//		else if (diff == -1)
		//		{
		//			score = 1;
		//		}

		//		if (score == 0)
		//		{
		//			break;
		//		}

		//		if (progress + score >= 100)
		//		{
		//			if (rankIndex == _ranks.Length - 1)
		//			{
		//				progress = 100;
		//				break;
		//			}
		//			else
		//			{
		//				progress = 0;
		//				rankIndex++;
		//			}
		//		}
		//		else
		//		{
		//			progress += score;
		//			break;
		//		}
		//	}
		//}

		public void incProgress(int rank)
		{
			if (!_ranks.Contains(rank))
			{
				throw new ArgumentException();
			}

			Console.WriteLine("----------");

			Console.WriteLine("user: " + this.rank);
			Console.WriteLine("task: " + rank);

			Console.WriteLine("before: " + progress);

			var rankIndex = Array.IndexOf(_ranks, rank);
			if (rankIndex < 0)
			{
				throw new ArgumentException();
			}

			if (this.rankIndex < _ranks.Length - 1)
			{
				var diff = rankIndex - this.rankIndex;
				if (diff > 0)
				{
					progress += 10 * diff * diff;
				}
				else if (diff == 0)
				{
					progress += 3;
				}
				else if (diff == -1)
				{
					progress += 1;
				}

				while (progress >= 100)
				{
					this.rankIndex++;

					if (this.rankIndex == _ranks.Length - 1)
					{
						progress = 0;
						break;
					}
					else
					{
						progress -= 100;
					}
				}
			}

			Console.WriteLine("after: " + progress);
		}
	}
}
