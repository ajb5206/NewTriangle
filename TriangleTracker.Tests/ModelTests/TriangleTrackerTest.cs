using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests 
{
	[TestClass]
	public class TriangleTrackerTests
	{
		[TestMethod]
		public void IsATriangle_Existence_True()
		{
			TriangleTracker testTriangleTracker = new TriangleTracker();
			Assert.AreEqual(true, testTriangleTracker.IsATriangle(3,4,5));
		}

		[TestMethod]
		public void IsATriangle_Existence_False()
		{
			TriangleTracker testTriangleTracker = new TriangleTracker();
			Assert.AreEqual(false, testTriangleTracker.IsATriangle(1,2,9));
		}
		[TestMethod]
		public void TypeOfTriangle_Type_Equilateral()
		{
			TriangleTracker testTriangleTracker = new TriangleTracker();
			Assert.AreEqual(________, testTriangleTracker.TypeOfTriangle(3,3,3));
		}
	}
}