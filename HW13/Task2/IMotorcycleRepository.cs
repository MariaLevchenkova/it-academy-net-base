namespace Task2
{
    public interface IMotorcycleRepository
    {
        List<Motorcycle> GetMotorcycles();
        
        Motorcycle GetMotorcycleById(int id);
        
        void AddMotocycle(Motorcycle motorcycle);
        
        void DeleteMotocycle(int id);
        
        void UpdateMotocycle(Motorcycle motorcycle);
    }
}