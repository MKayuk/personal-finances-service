using Microsoft.EntityFrameworkCore;

namespace PersonalFinancesService.Domain.Models;

[PrimaryKey(nameof(Id))]
public class CheckingAccount
{
    public int Id { get; set; }
    public string FinancialInstitutionName { get; set; } = string.Empty;
    public bool IsMain { get; set; }
    public IEnumerable<Investment> Investments {get; set; } = new List<Investment>(1);
    public IEnumerable<Entry> Entries { get; set; } = new List<Entry>(1);

}