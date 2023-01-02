using Common.Interfaces.Providers;
using System.Diagnostics.CodeAnalysis;

namespace Common.Providers
{
    /// <summary>
    /// Provides DateTimes to be used in place of the static methods
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class DateProvider : IDateProvider
    {
        /// <summary>
        /// Gets the current time in UTC
        /// </summary>
        public DateTime UTCNow
            => DateTime.UtcNow;

        /// <summary>
        /// Gets the current time on the server
        /// </summary>
        public DateTime Now
            => DateTime.Now;
    }
}
