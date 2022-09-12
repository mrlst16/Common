namespace Common.Interfaces.Utilities
{
    public interface IMapper<TIn, TOut>
    {
        TOut Map(TIn source);
    }

    public interface IMapper<TIn1, TIn2, TOut>
    {
        TOut Map(TIn1 source1, TIn2 source2);
    }

    public interface IMapper<TIn1, TIn2, TIn3, TOut>
    {
        TOut Map(TIn1 source1, TIn2 source2, TIn3 source3);
    }
}
