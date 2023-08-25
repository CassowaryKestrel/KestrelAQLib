namespace KestrelAQLib
{
    public class SubActionDeque
    {
        public Deque<Action> d;

        public Action? currentAction = null;

        public bool activated;
        public bool can_finish_action;

        public SubActionDeque()
        {
            d = new Deque<Action>();
            activated = false;
            can_finish_action = false;
        }

        public void Tick()
        {
            if (currentAction == null)
            {
                if (activated)
                {
                    currentAction = d.popFromFront();

                    if (currentAction != null)
                    {
                        currentAction.whenStarted();
                    }
                }
            }

            if (currentAction != null)
            {
                if (activated || can_finish_action)
                {
                    if (currentAction.Tick())
                    {
                        currentAction.whenFinished();

                        if (activated)
                        {
                            currentAction = d.popFromFront();

                            if (currentAction != null)
                            {
                                currentAction.whenStarted();
                            }
                        }
                        else
                        {
                            currentAction = null;
                        }
                    }
                }
                else
                {
                    currentAction = null;
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


        public void allowOneAction()
        {
            can_finish_action = true;
            currentAction = d.popFromFront();

            if (currentAction != null)
            {
                currentAction.whenStarted();
            }
        }
    }
}