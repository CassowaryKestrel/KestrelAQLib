// Wait for a specified amount of time to pass.
using KestrelAQLib;

public class A_WaitForTime : Action
{
    private float millis;
    private float counter = 0.0f;

    public A_WaitForTime(float _millis)
    {
        millis = _millis;
    }

    public override bool Tick()
    {
        if (counter > millis)
        {
            return true;
        }
        counter += Time.deltaTime;
        return false;
    }

    public override void whenStarted() { }

    public override void whenFinished() { }

    public override string toString()
    {
        return "Waiting for ( " + millis + " )";
    }
}
