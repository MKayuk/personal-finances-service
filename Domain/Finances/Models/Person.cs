namespace PersonalFinancesService.Domain.Models;

public class Person
{
    public IEnumerable<FinancialAccount> FinancialAccounts { get; set; }
    public IEnumerable<Objective> Objectives { get; set; }
}