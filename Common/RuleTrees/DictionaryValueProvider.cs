using Common.Interfaces.RuleTrees;

namespace Common.RuleTrees
{
    public class DictionaryValueProvider : IRuleTreeValueProvider
    {
        private readonly IDictionary<string, object> _source;

        public DictionaryValueProvider(
            IDictionary<string, object> source
            )
        {
            _source = source;
        }

        public async Task<object> GetValue(string key)
        {
            if (_source.TryGetValue(key, out object value))
                return value;
            return null;
        }
    }
}
