using Microsoft.EntityFrameworkCore;

namespace PersonalFinancesService.Domain.Models;

[PrimaryKey(nameof(Id))]
public class User
{
    public int Id { get; set; }
    public IEnumerable<CheckingAccount> CheckingAccounts { get; set; } = new List<CheckingAccount>(1);
    public IEnumerable<Goal> Goals { get; set; } = new List<Goal>(1);
}