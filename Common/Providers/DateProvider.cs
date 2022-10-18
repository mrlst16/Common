using Common.Interfaces.Providers;

namespace Common.Providers
{
    /// <summary>
    /// Provides DateTimes to be used in place of the static methods
    /// </summary>
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
