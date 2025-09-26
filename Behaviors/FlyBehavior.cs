namespace W5_assignment_template.Behaviors;

public class FlyBehavior
{
    private readonly Action _fly;

    public FlyBehavior(Action fly)
    {
        _fly = fly;
    }
    
    public void Fly() => _fly();
}