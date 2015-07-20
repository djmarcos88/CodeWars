using System;
using System.Collections;
using System.Collections.Generic;

public static class Kata
{
	public static int DescendingOrder(int num)
	{
		var array = num.toIntArray();

		return orderIntegersAscending(array);
	}

	public static int orderIntegersAscending(int[] integers)
	{
		int result = 0;
		List<int> integerList = new List<int>();
		int length = integers.Length;

		

		while (length > 0)
		{
			int control = 0;

			foreach (int integer in integers)
			{
				if (integer > control)
				{
					control = integer;
				}
				
			}


		}

		


		return result;
	}

	public static int[] toIntArray(this int num)
	{
		String str = num.ToString();
		char[] chars = str.ToCharArray();

		int[] array = new int[chars.Length];

		for (int i = 0; i < chars.Length; i++)
		{
			array[i] = Convert.ToInt32(chars[i]);
		}

		return array;
	}
}