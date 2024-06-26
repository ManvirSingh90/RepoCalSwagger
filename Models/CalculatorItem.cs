
namespace CalculatorAPI.Models
{
	public class CalculatorItem
	{
		public required string NumInput1 { get; set; }
		public required string NumInput2 { get; set; }
		public double Result { get; set; }
		public double CleanNum1 { get; set; }
		public double CleanNum2 { get; set; }
		public required string Operator { get; set; }
		public string Op { get; set; } = null!;
	}
}


