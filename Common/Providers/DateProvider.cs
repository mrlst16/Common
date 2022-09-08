using Common.Interfaces.Providers;

namespace Common.Providers
{
    public class DateProvider : IDateProvider
    {
        public DateTime UTCNow
            => DateTime.UtcNow;

        public DateTime Now
            => DateTime.Now;
    }
}
