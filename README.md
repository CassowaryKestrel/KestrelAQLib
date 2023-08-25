# KestrelAQLib
Kestrel Action Queueing Library for C#

## About
This library allows for queueing actions together. Designed specifically for game engines, where the game ticks once per frame, most notably Unity and MonoGame.


## Usage
### ActionDeque
Create an ActionDeque object:
```
var deque = new ActionDeque();
```

Create actions by overriding the following methods inheriting from KestrelAQLib.Action:

- WhenStarted: Called immediately upon switching to this action. Happens the same tick as an action finishing.
- Tick: Checks if the Action has been finished. Returns false if not finished, true if finished. Returning true will signal that the current action is complete, and the deque will move on to the next Action.
- WhenFinished: Called immediately upon an action finishing.

NOTE: The constructor is called immediately upon creating the Action object. Code that should begin when the Action is begun, should be placed in the WhenStarted() override instead.



## Example Actions
Wait for a thread to finish waiting before performing another action:
```
public class A_WaitForTime : Action
{
    private Task _timer;
    private int _time;

    public A_WaitForTime(int milliseconds)
    {
        _time = milliseconds;
    }

    public override bool Tick()
    {
        return _timer.IsCompletedSuccessfully;
    }

    public override void whenStarted()
    {
        _timer = Task.Run(() => Thread.Sleep(_time));
    }

    public override string ToString()
    {
        return "Waiting for " + _time.ToString() + " milliseconds";
    }
}
```
