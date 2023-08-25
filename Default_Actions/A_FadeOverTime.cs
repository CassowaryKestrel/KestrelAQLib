// Fade the color of a Text object from a starting transparency to a target transparency.
using KestrelAQLib;

public class A_FadeOverTime : Action
{
    private float start_trans;
    private float target_trans;
    private Text tmp;
    private float delay;
    private float counter = 0.0f;

    private Color starting_color;
    private Color target;

    public A_FadeOverTime(Text _tmp, float _starting_transparency, float _target_transparency, float _delay)
    {
        tmp = _tmp;
        target_trans = _target_transparency;
        start_trans = _starting_transparency;
        delay = _delay;
    }

    public override bool Tick()
    {
        tmp.color = Vector4.MoveTowards(starting_color, target, counter / delay);

        if (counter > delay)
        {
            return true;
        }
        counter += Time.deltaTime;
        return false;
    }

    public override void whenStarted()
    {
        starting_color = tmp.color;
        starting_color.a = start_trans;
        target = tmp.color;
        target.a = target_trans;
    }
    public override void whenFinished() { }


    public override string toString()
    {
        return "FADING";
    }
}
