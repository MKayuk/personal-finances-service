namespace PersonalFinancesService.Domain.Models;

public class Goal {
    public string Description { get; set; } = string.Empty;
    public DateTime Deadline { get; set; }
    public IEnumerable<Investment> Investments { get; set; } = new List<Investment>(1);
    public decimal TargetValue { get; set; }
}