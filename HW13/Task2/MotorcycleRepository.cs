using Serilog;

namespace Task2
{
    public class MotorcycleRepository : IMotorcycleRepository
    {
        private List<Motorcycle> _motos = new List<Motorcycle>();

        public MotorcycleRepository(List<Motorcycle> motos)
        {
            _motos = motos;
        }

        public List<Motorcycle> GetMotorcycles()
        {
            Log.Information("Motorcycles {0} read.", _motos.Count);
            return _motos;
        }

        public Motorcycle GetMotorcycleById(int id)
        {
            Motorcycle m = _motos.FirstOrDefault(m => m.Id == id);
            if (m == null)
            {
                throw new MotorcycleNotFoundException();
            }

            Log.Information("Motorcycle {0} found.", m.Id);
            return m;
        }

        public void AddMotocycle(Motorcycle motorcycle)
        {
            _motos.Add(motorcycle);
            Log.Information("Motorcycle {0} added.", motorcycle.Id);
        }

        public void DeleteMotocycle(int id)
        {
            var m = GetMotorcycleById(id);

            _motos.Remove(m);
            Log.Information("Motorcycle {0} removed.", id);
        }

        public void UpdateMotocycle(Motorcycle motorcycle)
        {
            var m = GetMotorcycleById(motorcycle.Id);

            m.Name = motorcycle.Name;
            m.Model = motorcycle.Model;
            m.Year = motorcycle.Year;
            m.Odometer = motorcycle.Odometer;

            Log.Information("Motorcycle {0} updated.", m.Id);
        }
    }
}
