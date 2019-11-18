using LegacyConsole.Utilities.AutoMapper;

namespace LegacyConsole
{
    public class Startup
    {
        public static void ConfigureServices()
        {
            AutoMapperConfiguration.Configure();
        }
    }
}
