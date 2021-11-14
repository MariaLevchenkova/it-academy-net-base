namespace HW_03;

internal class Company
{
    private List<Engineer> engineers = new List<Engineer>();

    public void Add(Engineer engineer)
    {
        engineers.Add(engineer);
    }

    public List<Engineer> Engineers =>
        engineers.OrderByDescending(x => x.Experience).ToList();

    public void ShowEmployees()
    {
        foreach (var engineer in Engineers)
        {
            Show(engineer);
        }
    }

    private void Show(Engineer engineer)
    {
        Console.WriteLine  ("Company:  , Full Name: , Experience: , Title:, Salary:, GitHub:       "); 
    }
}
