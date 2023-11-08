namespace PersonalFinancesService.Services.Interfaces;
public interface IImportService {

    Task<bool> ImportFromCSV(string path);
}