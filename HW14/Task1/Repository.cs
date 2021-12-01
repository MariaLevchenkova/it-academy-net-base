using Serilog;

namespace Task1
{

    public class Repository<T>: IRepository<T>
        where T : IItem
    {

        private List<T> _values = new List<T>();

        public Repository(List<T> values)
        {
            _values = values;
        }

        public void Add(T value)
        {
             _values.Add(value);
            Log.Information("Motorcycle {0} added.", value.Id);
        }

        public void Delete(int id)
        {
          var m = GetById(id);

            _values.Remove(m);
            Log.Information("Motorcycle {0} removed.", id);
        }

        public List<T> Get()
        {
            return _values;
        }

        public T GetById(int id)
        {
            T m = _values.FirstOrDefault(m => m.Id == id);
            if (m == null)
            {
                throw new NotFoundException();
            }

            Log.Information("Motorcycle {0} found.", m.Id);
            return m;
        }

        public void Update(T value)
        {
            int index = _values.FindIndex(x => x.Id == value.Id);

            if(index == -1)
            {
                throw new NotFoundException();
            }

            _values[index] = value;

            Log.Information("Motorcycle {0} updated.", value.Id);
        }
    }
}

