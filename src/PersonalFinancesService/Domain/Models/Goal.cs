using Microsoft.EntityFrameworkCore;

namespace PersonalFinancesService.Domain.Models;

[PrimaryKey(nameof(Id))]
public class Goal
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime Deadline { get; set; }
    public IEnumerable<Investment> Investments { get; set; } = new List<Investment>(1);
    public decimal TargetValue { get; set; }
}