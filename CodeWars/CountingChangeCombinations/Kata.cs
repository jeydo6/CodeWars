using System.Linq;

namespace CodeWars.CountingChangeCombinations
{
	public class Kata
	{
		public static int CountCombinations(int money, int[] coins)
		{
			if (money < 0 || coins.Length == 0)
			{
				return 0;
			}
			else if (money == 0)
			{
				return 1;
			}
			else
			{
				return CountCombinations(money - coins[0], coins) + CountCombinations(money, coins.Skip(1).ToArray());
			}
		}
	}
}
