using Holism.Api;

namespace Holism.Configuration.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Startup.AddControllerSearchAssembly(typeof(Controllers.ConfigurationItemController).Assembly);
            Holism.Api.Config.ConfigureEverything();
            Application.Run();
        }
    }
}
