using Game.Core.Modding;
using ILogger = Core.Logging.ILogger;

public class ExampleMod : IMod
{
    // Konstruktor: Wird in der Phase "Instantiated" aufgerufen
    public ExampleMod(ILogger logger)
    {
        logger.Info?.Log("Hello, shapez 2");
    }

    // Wird beim Entladen/Beenden aufgerufen (Shutdown)
    public void Dispose()
    {
    }
}