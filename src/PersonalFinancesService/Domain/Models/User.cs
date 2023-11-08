namespace PersonalFinancesService.Domain.Models;

public class User
{
    public IEnumerable<CheckingAccount> CheckingAccounts { get; set; } = new List<CheckingAccount>(1);
    public IEnumerable<Goal> Goals { get; set; } = new List<Goal>(1);
}