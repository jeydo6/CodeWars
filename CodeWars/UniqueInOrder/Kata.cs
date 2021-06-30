using System.Collections.Generic;

namespace CodeWars.UniqueInOrder
{
	public class Kata
	{
		//public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
		//{
		//	var result = new List<T>();
		//	var enumerator = iterable.GetEnumerator();
		//	while (enumerator.MoveNext())
		//	{
		//		if (result.Count == 0 || !result[^1].Equals(enumerator.Current))
		//		{
		//			result.Add(enumerator.Current);
		//		}
		//	}
		//	return result;
		//}

		public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
		{
			T previous = default;
			foreach (T current in iterable)
			{
				if (!current.Equals(previous))
				{
					previous = current;
					yield return current;
				}
			}
		}
	}
}
