namespace CalculatorAPI.Calculator_Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class SClassTests
{
	private SClass calculator;

	[TestInitialize]
	public void Setup()
	{
		calculator = new SClass();
	}

	[TestMethod]
	public void Add_WhenCalledWithTwoNumbers_ReturnsTheirSum()
	{
		double num1 = 10;
		double num2 = 5;

		double result = calculator.Add(num1, num2);

		Assert.AreEqual(15, result);
	}

	[TestMethod]
	public void Subtract_WhenCalledWithTwoNumbers_ReturnsTheirDifference()
	{
		double num1 = 10;
		double num2 = 5;

		double result = calculator.Subtract(num1, num2);

		Assert.AreEqual(5, result);
	}

	[TestMethod]
	public void Multiply_WhenCalledWithTwoNumbers_ReturnsTheirProduct()
	{
		double num1 = 10;
		double num2 = 5;

		double result = calculator.Multiply(num1, num2);

		Assert.AreEqual(50, result);
	}

	[TestMethod]
	public void Divide_WhenCalledWithTwoNumbers_ReturnsTheirQuotient()
	{
		double num1 = 10;
		double num2 = 5;

		double result = calculator.Divide(num1, num2);

		Assert.AreEqual(2, result);
	}


	[TestMethod]
	public void Divide_WhenCalledWithZeroDenominator_ThrowsDivideByZeroException()
	{
		double num1 = 10;
		double num2 = 10;

		double result = calculator.Divide(num1, num2);

		Assert.ThrowsException<DivideByZeroException>(() => result);
	}

	[TestMethod]
	public void Add_WhenCalledWithNegativeNumber_ReturnsTheirSum()
	{
		double num1 = 10;
		double num2 = -2;

		double result = calculator.Add(num1, num2);
		Assert.AreEqual(8, result);
	}

	[TestMethod]
	public void Subtract_WhenCalledWithNegativeNumber_ReturnsTheirDifference()
	{
		double num1 = 10;
		double num2 = -34;

		double Result = calculator.Subtract(num1, num2);
		Assert.AreEqual(44, Result);
	}

	[TestMethod]
	public void Multiply_WhenCalledWithZeroNumber_ReturnsTheirProduct()
	{
		double num1 = 0;
		double num2 = 5;

		double Result = calculator.Multiply(num1, num2);
		Assert.AreEqual(0, Result);
	}

	[TestMethod]
	public void Multiply_WhenCalledWithNegativeNumber_ReturnsTheirProduct()
	{
		double num1 = -10;
		double num2 = 2;

		double Result = calculator.Multiply(num1, num2);
		Assert.AreEqual(-20, Result);
	}
}


