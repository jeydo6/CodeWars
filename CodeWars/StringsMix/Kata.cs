using System.Linq;

namespace CodeWars.StringsMix
{
	public class Kata
	{
		public static string Mix(string s1, string s2)
		{
			var group1 = s1
				.Where(c => char.IsLower(c) && char.IsLetter(c))
				.GroupBy(a => a, b => b)
				.Select(a => new
				{
					a.Key,
					Count = a.Count()
				});

			var group2 = s2
				.Where(c => char.IsLower(c) && char.IsLetter(c))
				.GroupBy(a => a, b => b)
				.Select(a => new
				{
					a.Key,
					Count = a.Count()
				});

			var group12 = group1.Concat(group2)
				.GroupBy(a => a.Key, b => b);

			var grouped = group12.Select(a => new
			{
				a.OrderByDescending(p => p.Count).First().Count,
				a.Key,
				Result = s1.Count(i => i == a.Key) > s2.Count(i => i == a.Key) ? "1" : s1.Count(i => i == a.Key) < s2.Count(i => i == a.Key) ? "2" : "="
			});

			return string.Join("/", grouped
				.Where(o => o.Count > 1)
				.OrderByDescending(o => o.Count)
				.ThenBy(o => int.Parse(o.Result == "=" ? "3" : o.Result))
				.ThenBy(o => o.Key)
				.Select(g => g.Result + ":" + new string(g.Key, g.Count))
			);
		}
	}
}
