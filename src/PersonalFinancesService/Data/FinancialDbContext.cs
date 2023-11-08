using Microsoft.EntityFrameworkCore;
using PersonalFinancesService.Domain.Models;

namespace PersonalFinancesService.Data;

public class FinancialContext : DbContext
{
    public FinancialContext(DbContextOptions<FinancialContext> options)
        : base(options)
    {

    }

    public DbSet<CheckingAccount> CheckingAccounts { get; set; }
    public DbSet<Entry> Entries { get; set; }
    public DbSet<Goal> Goals { get; set; }
    public DbSet<User> Users { get; set; }

}