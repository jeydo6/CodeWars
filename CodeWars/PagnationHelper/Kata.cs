﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.PagnationHelper
{
	public class Kata
	{
		public static bool GetResult()
		{
			var helper = new PagnationHelper<int>(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 }, 10);

			var test1 = helper.PageIndex(12);

			return false;
		}
	}
}
