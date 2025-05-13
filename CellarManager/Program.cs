namespace CellarManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStorage storage = new JsonStorage(); // o CsvStorage
            ILogic logic = new BusinessLogic(storage);
            var ui = new Tui(logic);
            ui.Start(); // Avvia la tua interfaccia da console
        }
    }
}
