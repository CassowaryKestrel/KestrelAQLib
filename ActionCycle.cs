namespace KestrelAQLib
{
    public class ActionCycle
    {
        private List<Action> action_list;
        public int num_actions;

        public ActionCycle(List<Action> _action_list)
        {
            action_list = new List<Action>(_action_list);
            num_actions = action_list.Count;
        }

        public List<Action> getActions()
        {
            List<Action> new_actions = new List<Action>();

            foreach (Action a in action_list)
            {
                new_actions.Add(a.ShallowCopy());
            }

            return new_actions;
        }

    }
}