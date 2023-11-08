namespace PersonalFinancesService.Domain.Models;

public class CheckingAccount
{
    public int Id { get; set; }
    public string FinancialInstitutionName { get; set; } = string.Empty;
    public bool IsMain { get; set; }
    public IEnumerable<Entry> Entries { get; set; } = new List<Entry>(1);

}