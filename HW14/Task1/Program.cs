using Serilog;
using Task1;

namespace Task1;
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

        var values = new List<Motorcycle>
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
        IRepository<Motorcycle> repository = new Repository<Motorcycle> (values);

        var all = repository.Get();

        repository.Add(new Motorcycle  { Id = 3, Name = "Moto3", Model = "Minsk", Odometer = 6, Year = 2021 });

        try
        {
            Motorcycle moto3 = repository.GetById(3);
            moto3.Odometer++;
            repository.Update(moto3);

            repository.Delete(3);

            moto3 = repository.GetById(3);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Smth went wrong.");
        }

        Log.Information("Application {0} successfully finished.", typeof(Program).Namespace);
        Log.CloseAndFlush();
    }
}

