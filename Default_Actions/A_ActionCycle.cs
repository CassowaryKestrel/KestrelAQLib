using KestrelAQLib;
using Action = KestrelAQLib.Action;

public class A_ActionCycle : Action
{
    private ActionCycle cycle;
    private ActionDeque d;

    public A_ActionCycle(ActionCycle _cycle)
    {
        d = new ActionDeque();
        cycle = _cycle;
    }

    public override bool Tick()
    {
        d.Tick();

        if (d.currentAction == null && d.peekAtFront() == null)
        {
            if (end_flag)
                return true;

            List<Action> cycle_actions = cycle.getActions();

            foreach (Action a in cycle_actions)
                d.addToBack(a);
        }

        // If d becomes empty, add the action cycle's actions again

        return false;
    }

    public override void whenStarted()
    {
        // Add the action cycle's actions to d.
    }

    public override void whenFinished() { }

    public override string toString()
    {
        return "ACTION CYCLING";
    }
}
