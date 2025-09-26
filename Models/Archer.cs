using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class Archer : IEntity, IShootable
{
    public string Name { get; set; }

    public void Move()
    {
        Console.WriteLine($"{Name} moves swiftly into position.");
    }
    
    public void Attack(IEntity target)
    {
        Console.WriteLine($"{Name} strikes with a dagger at {target.Name}.");
    }
    
    public void Shoot()
    {
        Console.WriteLine($"{Name} fires an arrow.");
    }
}