// Sets the text of a Text object to an empty string "".
using KestrelAQLib;

public class A_EmptyText : Action
{
    private Text t_obj;

    public A_EmptyText(Text _t_obj)
    {
        t_obj = _t_obj;
    }

    public override bool Tick()
    {
        t_obj.text = "";
        return true;
    }

    public override void whenStarted() { }
    public override void whenFinished() { }
    public override string toString() { return "Emptying Text"; }
}
