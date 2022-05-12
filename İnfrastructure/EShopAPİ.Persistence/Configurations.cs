using Microsoft.Extensions.Configuration;

namespace EShopAPİ.Persistence;

static class Configurations
{
    public static string GetConnectionString()
    {
        ConfigurationManager configurationManager = new(); //Microsoft.Extensions.Configuration
        configurationManager.SetBasePath(
            Path.Combine(Directory.GetCurrentDirectory(),
                "../../Presentation/EShopAPi.APİ")); //Microsoft.Extensions.Configuration.json
        configurationManager.AddJsonFile("appsettings.json"); //Microsoft.Extensions.Configuration.json
        return configurationManager.GetConnectionString("MsSql");
    }
}