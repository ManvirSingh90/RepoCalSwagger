﻿namespace CalculatorAPI.Calculator_Services
{
	public class SClass
	{
		public double Add(double num1, double num2)
		{
			return num1 + num2;
		}
		public double Subtract(double num1, double num2)
		{
			return num1 - num2;
		}
		public double Multiply(double num1, double num2)
		{
			return num1 * num2;
		}

		public double Divide(double num1, double num2)
		{
			if (num2 == 0)
			{
				Console.WriteLine(" division by 0 is not allowed");
			}
			return num1 / num2;
		}
	}
}
