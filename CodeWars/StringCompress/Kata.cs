using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars.StringCompress
{
	public class Kata
	{
		//public static string Compress_BETA()
		//{
		//	var test1 = BurrowsWheelerTransformation.Kata.Encode("WONDERLAND");
		//	var test2 = BurrowsWheelerTransformation.Kata.Decode(test1.Result, test1.Index);

		//	using (var sr = File.OpenText("input.txt"))
		//	using (var sw = File.AppendText("output-encoded.txt"))
		//	{
		//		string line;
		//		while ((line = sr.ReadLine()) != null)
		//		{
		//			//var encodedLine = EncodeLine(line);
		//			var transformedLine = BurrowsWheelerTransformation.Kata.Encode(line);
		//			var encodedLine = $"{transformedLine.Index}_{RunLengthEncoding.Kata.Encode(transformedLine.Result)}";

		//			sw.WriteLine(encodedLine);
		//		}
		//	}

		//	return "";
		//}

		//private static string EncodeLine(string line)
		//{
		//	var test1 = BurrowsWheelerTransformation.Kata.Encode(line);
		//	var result = Regex.Replace(line, @"(\b[^\s]+\b)", new MatchEvaluator(m =>
		//	{
		//		if (!string.IsNullOrWhiteSpace(m.Value))
		//		{
		//			var transformed = BurrowsWheelerTransformation.Kata.Encode(m.Value);
		//			var compressed = $"{transformed.Index}_{RunLengthEncoding.Kata.Encode(transformed.Result)}";

		//			return compressed;
		//		}
		//		else
		//		{
		//			return m.Value;
		//		}
		//	}));

		//	return result;

		//	//var test = Regex.Split(line, @"\W+")
		//	//	.Where(w => !string.IsNullOrWhiteSpace(w))
		//	//	.Select(w => BurrowsWheelerTransformation.Kata.Encode(w))
		//	//	.Select(t => $"{t.Item2}_{RunLengthEncoding.Kata.Encode(t.Item1)}")
		//	//	.ToArray();
		//	//return "";
		//}
	}
}
