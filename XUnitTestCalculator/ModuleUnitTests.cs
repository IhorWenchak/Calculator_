using Calculator;
using System;
using Xunit;

namespace XUnitTestCalculator
{
	public class ModuleUnitTests
	{
		[Fact]
		public void TestGetPointResult()
		{
			SimpleMode simple = new SimpleMode("4*8/2");

			double result = simple.GetPointResult("4*8/2");

			double expected = 16;

			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestMainSeparator()
		{
			SimpleMode simple = new SimpleMode("2+2*3");

			double[] result = simple.MainSeparator("2+2*3");

			double[] expected = new double[] { 2, 6 };

			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestGetResult()
		{
			SimpleMode simple = new SimpleMode("2+2*3");

			double result = simple.GetResult(simple.SymbolsArray, simple.PriorityOperArray);

			double expected = 8;

			Assert.Equal(expected, result);

		}

		[Fact]
		public void TestExpressionError()
		{
			HardMode hd = new HardMode();

			string s = "1+x+4";

			bool result = hd.ExpressionError();

			bool expected = false;

			Assert.Equal(expected, result);

		}

		[Fact]
		public void TestBracketsProcessing()
		{
			HardMode hd = new HardMode();

			string result = hd.BracketsProcessing("1 + 2 * (3 + 2)");

			string expected = "1 + 2 * 5";

			Assert.Equal(expected, result);

		}
	}
}
