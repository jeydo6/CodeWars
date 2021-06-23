using System.Linq;

namespace CodeWars.Morse
{
	class Morse1
	{
		public static string Decode(string morseCode)
		{
			return string.Join(" ", morseCode
				.Trim()
				.Split("   ")
				.Select(morseWord => string.Join("", morseWord
						.Split(' ')
						.Select(morseChar => MorseCode.Get(morseChar))
					)
				)
			);
		}
	}
}
