using System;
using System.Collections;

public static class Kata
{
	public static int DescendingOrder(int num)
	{
		int result = 0;

		var array = num.toIntArray();

		sortIntegersAscendingHelper comparer = new sortIntegersAscendingHelper();
		Array.Sort(array, comparer);

		result = int.Parse(String.Concat(array));

		return result;
	}

	public class sortIntegersAscendingHelper : IComparer
	{
		int IComparer.Compare(object a, object b)
		{
			int c1 = (int)a;
			int c2 = (int)b;
			if (c1 < c2)
				return 1;
			if (c1 > c2)
				return -1;
			else
				return 0;
		}
	}

	public static int[] toIntArray(this int num)
	{
		String str = num.ToString();
		char[] chars = str.ToCharArray();

		int[] array = new int[chars.Length];

		for (int i = 0; i < chars.Length; i++)
		{
			array[i] = Convert.ToInt32(chars[i].ToString());
		}

		return array;
	}
}