using KestrelAQLib;
using Action = KestrelAQLib.Action;

public class A_WaitForDequeToFinish : Action
{
    private SubActionDeque d;

    public A_WaitForDequeToFinish(SubActionDeque _d)
    {
        d = _d;
    }

    public override bool Tick()
    {
        if (d.currentAction == null)
            return true;
        return false;
    }

    public override void whenStarted() { }
    public override void whenFinished() { }

    public override string toString()
    {
        return "WAITING FOR DEQUE TO BE EMPTY. HUNG ACTION IS " + d.currentAction.toString();
    }
}
