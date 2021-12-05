using Serilog;
using Task2;
namespace Task2
{
    class Program
    {
        public static void Main()
        {
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console()
            .WriteTo.File("log.txt",
                rollingInterval: RollingInterval.Hour,
                rollOnFileSizeLimit: true)
            .CreateLogger();

            Log.Information("Application {0} started.", typeof(Program).Namespace);

            var motos = new List<Motorcycle> 
            {
                new Motorcycle
                {
                    Id = 1,
                    Name = "Moto1",
                    Model = "Honda",
                    Odometer = 42,
                    Year = 2021
                },
                new Motorcycle 
                {
                    Id=2,
                    Name = "Moto2",
                    Model = "Ducati",
                    Odometer = 13,
                    Year = 2021
                }
            };
            IMotorcycleRepository repository = new MotorcycleRepository(motos);

            var all = repository.GetMotorcycles();

            repository.AddMotocycle(new Motorcycle { Id = 3, Name = "Moto3", Model = "Minsk", Odometer = 6, Year = 2021 });

            try
            {
                Motorcycle moto3 = repository.GetMotorcycleById(3);
                moto3.Odometer++;
                repository.UpdateMotocycle(moto3);

                repository.DeleteMotocycle(3);

                moto3 = repository.GetMotorcycleById(3);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Smth went wrong.");
            }

            Log.Information("Application {0} successfully finished.", typeof(Program).Namespace);
            Log.CloseAndFlush();
        }
    }
}


