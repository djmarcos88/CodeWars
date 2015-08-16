using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class VasyaAndStairs
	{
		[TestMethod]
		public void VasyaAndStairsTest1()
		{
			Assert.AreEqual(6, Stairs.NumberOfSteps(10, 2));
		}

		[TestMethod]
		public void VasyaAndStairsTest2()
		{
			Assert.AreEqual(-1, Stairs.NumberOfSteps(3, 5));
		}

		[TestMethod]
		public void VasyaAndStairsTest3()
		{
			Assert.AreEqual(5000, Stairs.NumberOfSteps(9999, 2));
		}

		[TestMethod]
		public void VasyaAndStairsTest4()
		{
			Assert.AreEqual(5004, Stairs.NumberOfSteps(9999, 9));
		}

		[TestMethod]
		public void VasyaAndStairsTest5()
		{
			Assert.AreEqual(10, Stairs.NumberOfSteps(20, 10));
		}

		[TestMethod]
		public void VasyaAndStairsTest6()
		{
			Assert.AreEqual(10, Stairs.NumberOfSteps(18, 10));
		}

		[TestMethod]
		public void VasyaAndStairsTest7()
		{
			Assert.AreEqual(-1, Stairs.NumberOfSteps(1, 2));
		}
	}
}
