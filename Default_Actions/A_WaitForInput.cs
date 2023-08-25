// Simply wait for the user to input a certain target key.
using KestrelAQLib;

public class A_WaitForInput : Action
{
    KeyCode key;

    public A_WaitForInput(KeyCode _key)
    {
        key = _key;
    }

    public override bool Tick()
    {
        if (Input.GetKey(key))
            return true;
        else
            return false;
    }

    public override void whenStarted() { }
    public override void whenFinished() { }

    public override string toString()
    {
        return "Waiting For Key";
    }
}
