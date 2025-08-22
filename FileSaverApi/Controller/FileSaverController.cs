using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileSaverApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileSaverController : ControllerBase
    {
        private readonly string _filePath = "log.txt";

        [HttpPost]
        public async Task<IActionResult> ExecuteAction(Kat kat)
        {
            await System.IO.File.AppendAllTextAsync(_filePath, $"{DateTime.Now}: {kat.Id}, {kat.Name}, {kat.Weight}\n");
            return Ok(new {message = "Acción realizada con éxito!!!"});
        }
    }
}
