using System.Collections.Immutable;
using DocumentFormat.OpenXml.Vml.Office;
using Microsoft.EntityFrameworkCore;
using PersonalFinancesService.Data;
using PersonalFinancesService.Mappers;

namespace PersonalFinancesService.Services;

public class ImportService
{
    private readonly FinancialContext _financialContext;
    public ImportService(FinancialContext financialContext)
    {
        _financialContext = financialContext;
    }

    public async Task<bool> ImportFromCSV(string path)
    {

        var entries = File.ReadAllLines(path)
                            .Skip(1)
                            .Select(v => EntryMapper.FromCustomCSV(v))
                            .ToImmutableList();

        foreach (var entry in entries)
        {
            _financialContext.Entries.Add(entry);
            await _financialContext.SaveChangesAsync();
        }
        return true;
    }
}