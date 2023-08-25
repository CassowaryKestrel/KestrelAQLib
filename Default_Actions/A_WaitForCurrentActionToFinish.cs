// Specialized Action that can be used in one action queue to detect whether another action queue has
// finished its current action.
using KestrelAQLib;

public class A_WaitForCurrentActionToFinish : Action
{
    private SubActionDeque d;

    public A_WaitForCurrentActionToFinish(SubActionDeque _d)
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
        return "WAITING FOR CURRENT ACTION TO FINISH";
    }
}
