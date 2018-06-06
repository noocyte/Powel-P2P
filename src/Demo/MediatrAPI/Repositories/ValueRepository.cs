using System.Collections.Generic;

namespace MediatrAPI.Repositories
{
    public interface IValueRepository
    {
        IEnumerable<string> GetValues();
        string GetValue(int id);
        IEnumerable<string> StoreValue(string value);
    }

    public class ValueRepository : IValueRepository
    {
        private readonly List<string> _values = new List<string>();

        public string GetValue(int id)
        {
            if (_values.Count >= id) return _values[id];
            return string.Empty;
        }

        public IEnumerable<string> GetValues()
        {
            return _values;
        }

        public IEnumerable<string> StoreValue(string value)
        {
            _values.Add(value);
            return _values;
        }
    }
}
