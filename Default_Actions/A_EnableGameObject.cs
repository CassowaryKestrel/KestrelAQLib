using KestrelAQLib;

public class A_EnableGameObject : Action
{
    private bool enabled;
    private GameObject o;

    public A_EnableGameObject(GameObject _o)
    {
        o = _o;
        enabled = true;
    }

    public A_EnableGameObject(GameObject _o, bool _enabled)
    {
        o = _o;
        enabled = _enabled;
    }

    public override bool Tick()
    {
        return true;
    }

    public override void whenStarted()
    {
        o.SetActive(enabled);
    }

    public override void whenFinished() { }

    public override string toString()
    {
        return "ENABLING GAME OBJECT";
    }
}

public class A_DisableGameObject : Action
{
    private bool enabled;
    private GameObject o;

    public A_DisableGameObject(GameObject _o)
    {
        o = _o;
        enabled = false;
    }

    public override bool Tick()
    {
        return true;
    }

    public override void whenStarted()
    {
        o.SetActive(enabled);
    }

    public override void whenFinished() { }

    public override string toString()
    {
        return "DISABLING GAME OBJECT";
    }
}