using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.StopSpinningWords
{
	public class Kata
	{
		public static string SpinWords(string sentence)
		{
			return string.Join(" ", sentence
				.Split(" ")
				.Select(w => w.Length >= 5 ? string.Join("", w.Reverse()) : w)
			);
		}
	}
}
