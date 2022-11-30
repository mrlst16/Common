using Microsoft.Extensions.Configuration;

namespace Common.AspDotNet
{
    public class Helper
    {

        /// <summary>
        /// Add configurations based on the json formatted settings-file-paths passed
        /// </summary>
        /// <param name="paths">a list of file-paths to add to the configuration</param>
        /// <returns>configurations based on the json formatted settings-file-paths passed</returns>
        public IConfiguration GetConfigurationFromPaths(params string[] paths)
            => GetConfigurationFromPaths(Directory.GetCurrentDirectory(), paths);

        /// <summary>
        /// Add configurations based on the json formatted settings-file-paths passed
        /// </summary>
        /// <param name="baseDirectory">base directory to use</param>
        /// <param name="paths">a list of file-paths to add to the configuration</param>
        /// <returns>configurations based on the json formatted settings-file-paths passed</returns>
        /// <exception cref="Exception"></exception>
        public IConfiguration GetConfigurationFromPaths(string baseDirectory, params string[] paths)
        {
            if (!paths?.Any() ?? true) throw new Exception("paths must be populated");

            var builder = new ConfigurationBuilder()
                .SetBasePath(baseDirectory);

            foreach (var path in paths)
                builder = builder.AddJsonFile(path, optional: true, reloadOnChange: true);

            return builder.Build();
        }

        /// <summary>
        /// Looks for appsettings.json and appsettings.{ASPNETCORE_ENVIRONMENT}.json and uses them
        /// to construct a configuration object
        /// </summary>
        /// <returns>Configuration object based on the the appsettings.json
        /// and appsettings.{ASPNETCORE_ENVIRONMENT}.json
        /// </returns>
        public IConfiguration GetConfigFromFile()
            => GetConfigurationFromPaths(paths: new[] { "appsettings.json", $"appsettings.{Environment()}.json" });

        /// <summary>
        /// Gets the ASPNETCORE_ENVIRONMENT variable
        /// </summary>
        /// <returns>The ASPNETCORE_ENVIRONMENT variable</returns>
        public static string Environment()
            => System.Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? string.Empty;
    }
}
