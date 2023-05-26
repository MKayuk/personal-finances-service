using PersonalFinancesService.Domain.Enums;

namespace PersonalFinancesService.Domain.Models;

public class Entry
{
    string Classification { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Establishment { get; set; } = string.Empty;
    public FinancialAccount FinancialAccount { get; set; } = new FinancialAccount();
    public bool Fixed { get; set; } = false;
    public int Installment { get; set; }
    public int TotalInstallments { get; set; }
    public IEnumerable<string>? Tags { get; set; }
    public EntryType Type { get; set; }
    public decimal Value { get; set; }
}