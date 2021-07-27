using System.Linq;

namespace CodeWars.HelpBookseller
{
	public class Kata
	{
		public static string StockSummary(string[] list, string[] categories)
		{
			if (
				list == null || list.Length == 0 ||
				categories == null || categories.Length == 0
			)
			{
				return string.Empty;
			}

			return string.Join(" - ", categories
				.GroupJoin(
					list,
					category => category,
					item => item[0..1],
					(category, list) => (
						Category: category, Count: list
						.Select(l => int.Parse(l.Split(" ")[1]))
						.Sum()
					)
				)
				.Select((t, _) => $"({t.Category} : {t.Count})")
			);
		}
	}
}
