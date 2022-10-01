using Microsoft.Extensions.Configuration;

namespace Common.Helpers
{
    public static class ConfigurationHelper
    {
        public static IConfiguration FromJsonFiles(string basePath, params string[] fileNames)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath);
            foreach (string filename in fileNames)
            {
                builder.AddJsonFile(filename, false, true);
            }
            return builder.Build();
        }

        public static IConfiguration FromJsonFiles(params string[] fileNames)
            => FromJsonFiles(Directory.GetCurrentDirectory(), fileNames);

        public static IConfiguration FromJsonFile()
            => FromJsonFiles(Directory.GetCurrentDirectory(), "appSettings.json");

        /// <summary>
        /// Adds "appSettings.json" and "appSettings.{environment}.json"
        /// </summary>
        /// <returns></returns>
        public static IConfiguration FromJsonFiles()
            => FromJsonFiles(Directory.GetCurrentDirectory(),
                "appSettings.json",
                $"appSettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json"
                );
    }
}
