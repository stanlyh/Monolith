

using Entities;
using FileSaver;
using Interfaces;

var kat = new Kat()
{
    Id = 1, 
    Name = "Evangeline", 
    Weight = 8.5m
};
var fileSave = new FileSave();
var execute = new Execute(fileSave);
execute.Save(kat);


public class Execute
{
    private readonly IActionService _actionService;

    public Execute(IActionService actionService)
    {
        _actionService = actionService;
    }

    public void Save(Kat kat)
    {
        _actionService.ExcecuteAction(kat);
    }

}