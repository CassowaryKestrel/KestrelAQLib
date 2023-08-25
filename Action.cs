namespace KestrelAQLib
{
    public abstract class Action
    {
        public bool end_flag = false;

        public abstract bool Tick();

        public virtual void whenStarted() { }

        public virtual void whenFinished() { }

        public virtual string toString() { return "Action"; }

        public Action ShallowCopy()
        {
            return (Action)MemberwiseClone();
        }
    }
}