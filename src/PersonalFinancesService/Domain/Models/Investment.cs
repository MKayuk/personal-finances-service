using Microsoft.EntityFrameworkCore;

namespace PersonalFinancesService.Domain.Models;

[PrimaryKey(nameof(Id))]
public class Investment
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double IncomeInterestRate { get; set; }
    public List<Entry> Entries { get; set; } = new List<Entry>(1);
}