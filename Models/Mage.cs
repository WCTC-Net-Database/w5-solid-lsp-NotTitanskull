using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class Mage : IEntity, ICastable
{
    public string Name { get; set; }

    public void Move()
    {
        Console.WriteLine($"{Name} glides forward, staff in hand.");
    }

    public void Attack(IEntity target)
    {
        Console.WriteLine($"{Name} whacks {target.Name} with the staff.");
    }

    public void CastSpell(string spellName)
    {
        Console.WriteLine($"{Name} casts {spellName}!");
    }
}