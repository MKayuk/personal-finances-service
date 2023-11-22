using PersonalFinancesService.Domain.Enums;

namespace PersonalFinancesService.Domain.Models;

public class MonthlyPlanning {
    public IDictionary<IncomeDistributionFactor, double>? IncomeDistributionFactors { get; set; } 
    public decimal EstimatedIncomeValue { get; set; }
}