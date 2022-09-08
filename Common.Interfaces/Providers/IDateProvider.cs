namespace Common.Interfaces.Providers
{
    public interface IDateProvider
    {
        DateTime UTCNow { get; }
        DateTime Now { get; }
    }
}