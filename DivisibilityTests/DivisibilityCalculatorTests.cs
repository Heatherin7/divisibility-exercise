using Divisibility;
using NUnit.Framework;

namespace DivisibilityTests
{
	public class DivisibilityCalculatorTests
	{
		private DivisibilityCalculator _calculator;

		[SetUp]
		public void Setup() => _calculator = new DivisibilityCalculator();

		[TestCase(10, 5, 2, true)]
		[TestCase(10, 5, 3, false)]
		[TestCase(12, 7, 4, false)]
		[TestCase(17, 2, 4, false)]
		[TestCase(12, 3, 0, false)]
		[TestCase(33, 0, 3, false)]
		[TestCase(0, 0, 99, false)]
		[TestCase(0, 7, 0, false)]
		[TestCase(-100, 50, -50, true)]
		public void Returns_True_If_A_Is_Divisible_By_B_And_C(int a, int b, int c, bool expectedResult)
		{
			var result = _calculator.CheckDivisibility(a, b, c);
			Assert.AreEqual(expectedResult, result);
		}
	}
}