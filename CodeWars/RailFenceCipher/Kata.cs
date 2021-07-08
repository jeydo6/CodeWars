using System;
using System.Linq;

namespace CodeWars.RailFenceCipher
{
	public class Kata
	{
		//public static string Encode(string str, int key)
		//{
		//	if (string.IsNullOrEmpty(str))
		//	{
		//		return "";
		//	}

		//	var rails = Enumerable
		//		.Range(0, key)
		//		.Select(_ => new Queue<char>())
		//		.ToArray();

		//	var rail = 0;
		//	var direction = 1;
		//	foreach (var ch in str)
		//	{
		//		rails[rail].Enqueue(ch);
		//		rail += direction;

		//		if (rail == 0 || rail == key - 1)
		//		{
		//			direction *= -1;
		//		}
		//	}

		//	return string.Join("", rails
		//		.Select(q => string.Join("", q))
		//	);
		//}

		//public static string Decode(string str, int key)
		//{
		//	if (string.IsNullOrEmpty(str))
		//	{
		//		return "";
		//	}

		//	var rails = Enumerable
		//		.Range(0, key)
		//		.Select(_ => new Queue<char>())
		//		.ToArray();

		//	var rail = 0;
		//	var direction = 1;
		//	foreach (var ch in str)
		//	{
		//		rails[rail].Enqueue(ch);
		//		rail += direction;

		//		if (rail == 0 || rail == key - 1)
		//		{
		//			direction *= -1;
		//		}
		//	}

		//	var temp = new Queue<char>(str);
		//	rails = rails
		//		.Select(r => new Queue<char>(
		//				r.Select(_ => temp.Dequeue())
		//			)
		//		)
		//		.ToArray();

		//	var result = "";
		//	rail = 0;
		//	direction = 1;
		//	foreach (var ch in str)
		//	{
		//		result += rails[rail].Dequeue();
		//		rail += direction;

		//		if (rail == 0 || rail == key - 1)
		//		{
		//			direction *= -1;
		//		}
		//	}

		//	return result;
		//}

		public static string Encode(string str, int key)
		{
			var period = 2 * (key - 1);
			return string.Concat(str
				.Select((ch, i) => new
				{
					Value = ch,
					Index = i
				})
				.OrderBy(o => Math.Min(o.Index % period, period - o.Index % period))
				.Select(o => o.Value)
			);
		}

		public static string Decode(string str, int key)
		{
			var period = 2 * (key - 1);
			var pattern = Enumerable
				.Range(0, str.Length)
				.OrderBy(i => Math.Min(i % period, period - i % period))
				.ToArray();

			return string.Concat(str
				.Zip(pattern, (ch, i) => new
				{
					Value = ch,
					Index = i
				})
				.OrderBy(o => o.Index)
				.Select(o => o.Value)
			);
		}
	}
}
