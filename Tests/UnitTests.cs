using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class UnitTests
	{
		[TestMethod]
		public void DescendingOrder()
		{
			Assert.AreEqual(0, Kata.DescendingOrder(0));

			Assert.AreEqual(321, Kata.DescendingOrder(213));

			Assert.AreEqual(98321, Kata.DescendingOrder(21398));

			Assert.AreEqual(987654321, Kata.DescendingOrder(123456789));
		} 
	}
}
