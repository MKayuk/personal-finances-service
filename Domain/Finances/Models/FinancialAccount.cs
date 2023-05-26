namespace PersonalFinancesService.Domain.Models;

public class FinancialAccount {
    public int Id { get; set; }
    public string FinancialInstitutionName { get; set; } = string.Empty;
    public bool Default { get; set; }

}