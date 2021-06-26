using System.Text;

namespace CodeWars.RangeExtraction
{
	public class Kata
	{
		public static string Extract(int[] args)
		{
			var sb = new StringBuilder();

			for (var i = 0; i < args.Length; i++)
			{
				var start = args[i];

				while (
					i + 1 < args.Length
					&& args[i + 1] - args[i] == 1
				)
				{

					++i;
				};

				var end = args[i];

				if (end == start)
				{
					sb.Append(start + ",");
				}
				else if (end - start == 1)
				{
					sb.Append($"{start},{end},");
				}
				else
				{
					sb.Append($"{start}-{end},");
				}
			}

			var result = sb
				.ToString()
				.TrimEnd(',');

			return result;
		}
	}
}
