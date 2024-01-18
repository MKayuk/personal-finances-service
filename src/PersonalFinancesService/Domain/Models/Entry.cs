using Microsoft.EntityFrameworkCore;
using PersonalFinancesService.Domain.Enums;

namespace PersonalFinancesService.Domain.Models;

[PrimaryKey(nameof(Id))]
public class Entry
{
    public int Id { get; set; }
    public string Classification { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Establishment { get; set; } = string.Empty;
    public string CheckingAccount { get; set; } = string.Empty;
    public bool IsFixed { get; set; } = false;
    public DateTime FixedUntil {get; set;}
    public int InstallmentNumber { get; set; }
    public int TotalInstallments { get; set; }
    public IEnumerable<string>? Tags { get; set; }
    public EntryType Type { get; set; }
    public int? GoalId { get; set; }
    public decimal Value { get; set; }
}