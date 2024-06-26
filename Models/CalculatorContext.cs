
using Microsoft.EntityFrameworkCore;

namespace CalculatorAPI.Models;

	public class CalculatorContext : DbContext
{
	public CalculatorContext(DbContextOptions<CalculatorContext> options )
		: base( options )
	{

	}
	public DbSet<CalculatorItem> CalculatorItems { get; set; } = null!;
}
     
