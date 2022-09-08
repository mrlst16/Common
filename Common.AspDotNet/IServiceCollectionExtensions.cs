using Common.Interfaces.Providers;
using Common.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace Common.AspDotNet
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddCommon(this IServiceCollection services)
            => services.AddTransient<IDateProvider, DateProvider>();
    }
}