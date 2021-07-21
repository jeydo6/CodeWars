using System.Collections.Generic;
using System.Linq;

namespace CodeWars.MexicanWave
{
	public class Kata
	{
		public List<string> Wave(string str)
		{
			return str
				.Select((ch, i) => str[0..i] + char.ToUpper(ch) + str[(i + 1)..])
				.Where(s => s != str)
				.ToList();
		}
	}
}
