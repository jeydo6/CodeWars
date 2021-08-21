using System.Collections.Generic;

namespace CodeWars.VowelCount
{
    public class Kata
    {
        public static int GetVowelCount(string str)
        {
            var hashSet = new HashSet<char>{ 'a', 'e', 'i', 'o', 'u' };

            var vowelCount = 0;
            for (var i = 0; i < str.Length; i++)
            {
                if (hashSet.Contains(str[i]))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }
}