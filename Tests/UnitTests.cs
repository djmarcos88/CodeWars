using System;
using CodeWars.CSharp;
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


		[TestMethod]
		public void DirReduction1()
		{
			string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
			string[] b = new string[] { "WEST" };
			Assert.AreEqual(b, DirReduction.dirReduc(a));
		}

		[TestMethod]
		public void DirReduction2()
		{
			string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
			string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
			Assert.AreEqual(b, DirReduction.dirReduc(a));
		}
	}
}
