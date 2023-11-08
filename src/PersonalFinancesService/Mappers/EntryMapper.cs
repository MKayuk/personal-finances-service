using PersonalFinancesService.Domain.Enums;
using PersonalFinancesService.Domain.Models;

namespace PersonalFinancesService.Mappers;

public static class EntryMapper
{
    public static Entry FromCustomCSV(string line)
    {
        string[] values = line.Split(',');

        return new Entry(){
            Type = Enum.Parse<EntryType>(values[0]),
            Classification = values[1],
            Category = values[2],
            CheckingAccount = values[3],
            Establishment = values[4],
            Description = values[5],
            InstallmentNumber = Convert.ToInt16(values[6]),
            Tags = values[7].Split(';'),
            Date = DateTime.Parse(values[8]),
            Value = Convert.ToDecimal(values[9])
        };
    }
}