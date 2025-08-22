using Entities;
using Interfaces;

namespace FileSaver
{
    public class FileSave : IActionService
    {
        private readonly string _filePath = "log.txt";
        public void ExcecuteAction(Kat kat)
        {
            File.AppendAllText(_filePath, $"{DateTime.Now}: {kat.Id}, {kat.Name}, {kat.Weight}\n");
        }
    }
}
