using System.Text.RegularExpressions;

namespace CodeWars.ConvertToCamelCase
{
	public class Kata
	{
		public static string ToCamelCase(string str)
		{
			return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
		}

		//public static string ToCamelCase(string str)
		//{
		//	if (string.IsNullOrWhiteSpace(str))
		//	{
		//		return "";
		//	}

		//	var result = string.Join("", str
		//		.Split(new string[] { "-", "_" }, StringSplitOptions.RemoveEmptyEntries)
		//		.Select(ToUpper)
		//	);

		//	if (char.IsLower(str[0]))
		//	{
		//		return ToLower(result);
		//	}
		//	return result;
		//}

		//private static string ToUpper(string str)
		//{
		//	return str.Length > 0 ?
		//		str.Length > 1 ? $"{char.ToUpper(str[0])}{str[1..]}" : $"{char.ToUpper(str[0])}" :
		//		"";
		//}

		//private static string ToLower(string str)
		//{
		//	return str.Length > 0 ?
		//		str.Length > 1 ? $"{char.ToLower(str[0])}{str[1..]}" : $"{char.ToLower(str[0])}" :
		//		"";
		//}
	}
}
