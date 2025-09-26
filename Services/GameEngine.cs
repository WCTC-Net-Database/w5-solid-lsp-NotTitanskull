using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly IEntity _archer;
        private readonly IEntity _mage;

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity archer, IEntity mage)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _archer = archer;
            _mage = mage;
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";
            _archer.Name = "Archer";
            _mage.Name = "Mage";

            _character.Move();
            _character.Attack(_goblin);

            _goblin.Move();
            _goblin.Attack(_character);

            _ghost.Move();
            _ghost.Attack(_character);
            if (_ghost is IFlyable flyable)
            {
                flyable.Fly();
            }
            
            _archer.Move();
            _archer.Attack(_goblin);
            if (_archer is IShootable shootable) shootable.Shoot();
            
            _mage.Move();
            _mage.Attack(_goblin);
            if (_mage is ICastable castable) castable.CastSpell("Fireball");
        }
    }
}
