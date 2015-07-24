using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


	public class DirReduction
	{
		public enum Directions
		{
			NORTH,
			SOUTH,
			WEST,
			EAST
		}

		public static string[] dirReduc(String[] arr)
		{
			List<string> plan = arr.ToList<string>();
			bool finished = false;

			while (finished == false)
			{
				bool foundReduction = false;
				List<string> newPlan = new List<string>();
				int counter = 0;

				for (counter = 0; counter < plan.Count; counter++)
				{
					if (counter < plan.Count - 1)
					{
						if (areOpposite(plan[counter], plan[counter + 1]))
						{
							foundReduction = true;
							counter++;
						}
						else {
							newPlan.Add(plan[counter]);
						} 
					}
					else if (counter == plan.Count - 1)
					{
						newPlan.Add(plan[counter]);
					}
				}

				plan = newPlan;
				finished = !foundReduction;
			}

			return plan.ToArray();
		}

		public static bool areOpposite(string a, string b)
		{
			bool result = false;

			if (a == Directions.NORTH.ToString() && b == Directions.SOUTH.ToString())
			{
				result = true;
			}
			else if (a == Directions.SOUTH.ToString() && b == Directions.NORTH.ToString())
			{
				result = true;
			}
			else if (a == Directions.WEST.ToString() && b == Directions.EAST.ToString())
			{
				result = true;
			}
			else if (a == Directions.EAST.ToString() && b == Directions.WEST.ToString())
			{
				result = true;
			}

			return result;
		}
	}

