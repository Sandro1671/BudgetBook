namespace Haushaltsbuch
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var app = Configurator.ConfigureServices(args);
            app = Configurator.ConfigureApp(app);
            await Configurator.ConfigureDatabaseAsync();
            await app.RunAsync();
        }
    }
}