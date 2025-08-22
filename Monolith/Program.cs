

using ClientFileSaver;
using Entities;
using FileSaver;
using Interfaces;

var kat = new Kat()
{
    Id = 1, 
    Name = "Evangeline", 
    Weight = 8.5m
};
//var fileSave = new FileSave();
var httpFileSaver = new HttpFileSaver();
var execute = new Execute(httpFileSaver);
await execute.Save(kat);


public class Execute
{
    private readonly IActionService _actionService;

    public Execute(IActionService actionService)
    {
        _actionService = actionService;
    }

    public async Task Save(Kat kat)
    {
        await _actionService.ExcecuteAction(kat);
    }

}