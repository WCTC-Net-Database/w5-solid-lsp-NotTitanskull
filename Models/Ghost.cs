using W5_assignment_template.Behaviors;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Ghost : IEntity, IFlyable
    {
        public string Name { get; set; }
        
        private readonly FlyBehavior _flyBehavior;

        public Ghost()
        {
            _flyBehavior = new FlyBehavior(Fly);
        }
        
        public void Fly()
        {
            Console.WriteLine($"{Name} flies rapidly through the air.");
        }

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} with a chilling touch.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} floats silently.");
        }
    }
}
