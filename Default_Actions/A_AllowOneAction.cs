using KestrelAQLib;

public class A_AllowOneAction : Action
{
    private SubActionDeque d;

    public A_AllowOneAction(SubActionDeque _d)
    {
        d = _d;
    }

    public override bool Tick()
    {
        d.allowOneAction();
        return true;
    }

    public override void whenStarted() { }
    public override void whenFinished() { }

    public override string toString()
    {
        return "ALLOWING ONE ACTION";
    }
}
