namespace KestrelAQLib
{
    public class ActionDeque
    {
        public Deque<Action> d;

        public Action? currentAction = null;

        public ActionDeque()
        {
            d = new Deque<Action>();
        }

        public void Tick()
        {
            if (currentAction == null)
            {
                currentAction = d.popFromFront();

                if (currentAction != null)
                {
                    currentAction.whenStarted();
                }
            }

            if (currentAction != null)
            {
                if (currentAction.Tick())
                {
                    currentAction.whenFinished();

                    currentAction = d.popFromFront();

                    if (currentAction != null)
                    {
                        currentAction.whenStarted();
                    }
                }
            }
        }

        public int size()
        {
            return d.size();
        }

        public void addToFront(Action a)
        {
            d.addToFront(a);
        }

        public void addToFront(Deque<Action> a)
        {
            d.addToFront(a);
        }

        public void addToFront(ActionDeque a)
        {
            d.addToFront(a.d);
        }

        public void addToBack(Action a)
        {
            d.addToBack(a);
        }

        public void addToBack(Deque<Action> a)
        {
            d.addToBack(a);
        }

        public void addToBack(ActionDeque a)
        {
            d.addToBack(a.d);
        }

        public Action peekAtFront()
        {
            return d.peekAtFront();
        }

        public Action peekAtBack()
        {
            return d.peekAtBack();
        }

        public Action popFromFront()
        {
            return d.popFromFront();
        }

        public Action popFromBack()
        {
            return d.popFromBack();
        }

        public void Clear(bool halt_current_action)
        {
            if (halt_current_action)
                currentAction = null;
            d.Clear();
        }

        public string toString()
        {
            return d.toString();
        }
    }
}