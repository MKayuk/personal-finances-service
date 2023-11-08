using Microsoft.AspNetCore.Mvc;
using PersonalFinancesService.Services.Interfaces;

namespace PersonalFinancesService.Controllers;

[ApiController]
[Route("[controller]")]
public class EntryController : ControllerBase 
{
    private readonly IImportService _importService;
    public EntryController(IImportService importService)
    {
        _importService = importService;
    }

    [HttpPost]
    public async Task<IResult> Import(string path)
    {   
       bool imported = false;
       
       if(!string.IsNullOrEmpty(path))
            imported = await _importService.ImportFromCSV(path);

        if(imported)
            return Results.Ok("File successfully imported!");

        return Results.BadRequest();
    }
}