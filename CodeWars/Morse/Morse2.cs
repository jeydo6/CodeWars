using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars.Morse
{
	class Morse2
	{
		public static string DecodeBits(string bits)
		{
			var timeUnit = Regex.Matches(bits.Trim('0'), @"(0+|1+)")
				.Select(m => m.Value.Length)
				.Min();

			var dot = new string('1', timeUnit);
			var dash = new string('1', timeUnit * 3);
			var pause1 = new string('0', timeUnit);
			var pause3 = new string('0', timeUnit * 3);
			var pause7 = new string('0', timeUnit * 7);

			BitsCode.Set(dot, ".");
			BitsCode.Set(dash, "-");
			BitsCode.Set(pause1, "");
			BitsCode.Set(pause3, " ");
			BitsCode.Set(pause7, "   ");

			var morseCode = string.Join(BitsCode.Get(pause7), bits
				.Trim('0')
				.Split(pause7)
				.Select(bitsWord =>
					string.Join(BitsCode.Get(pause3), bitsWord
						.Split(pause3)
						.Select(bitsChar => string.Join(BitsCode.Get(pause1), bitsChar
								.Split(pause1)
								.Select(bitsSignal => BitsCode.Get(bitsSignal))
							)
						)
					)
				)
			);

			return morseCode;
		}

		public static string DecodeMorse(string morseCode)
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
