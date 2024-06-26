using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CalculatorController : ControllerBase
	{
		[HttpGet("Add")]
		public ActionResult<double> Add(double num1, double num2)
		{
			return num1 + num2;
		}

		[HttpGet("Subtract")]
		public ActionResult<double> Subtract(double num1, double num2)
		{
			return num1 - num2;
		}

		[HttpGet("Multiply")]
		public ActionResult<double> Multiply(double num1,double num2)
		{
			return num1 * num2;
		}

		[HttpGet("Divide")]
		public ActionResult<double> Divide(double num1 , double num2) 
		{ 
		if(num2 == 0)
			{
				return BadRequest(" division by 0 is not allowed");
			}
		return num1 / num2;
		}
	}
}
