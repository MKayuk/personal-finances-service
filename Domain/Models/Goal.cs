namespace PersonalFinancesService.Domain.Models;

public class Goal {
    public decimal TargetValue { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime Deadline { get; set; }
    public double IncomeRate { get; set; }
    public IEnumerable<Entry> Entries { get; set; } = new List<Entry>(1);
}