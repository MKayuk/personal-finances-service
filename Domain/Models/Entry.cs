using PersonalFinancesService.Domain.Enums;

namespace PersonalFinancesService.Domain.Models;

public class Entry
{
    public string Classification { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Establishment { get; set; } = string.Empty;
    public CheckingAccount CheckingAccount { get; set; } = new CheckingAccount();
    public bool IsFixed { get; set; } = false;
    public int InstallmentNumber { get; set; }
    public int TotalInstallments { get; set; }
    public IEnumerable<string>? Tags { get; set; }
    public EntryType Type { get; set; }
    public int? GoalId { get; set; }
    public decimal Value { get; set; }
}