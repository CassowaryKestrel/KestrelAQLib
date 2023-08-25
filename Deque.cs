namespace KestrelAQLib
{
    public class Deque<T>
    {
        public List<T> d;

        public Deque()
        {
            d = new List<T>();
        }

        public Deque(Deque<T> _d)
        {
            d = new List<T>();
            for (int i = 0; i < _d.size(); i++)
            {
                d.Add(_d.d[i]);
            }
        }

        public int size()
        {
            return d.Count;
        }

        public void Clear()
        {
            d.Clear();
        }

        public void addToFront(T t)
        {
            d.Insert(0, t);
        }

        public void addToFront(Deque<T> t)
        {
            Deque<T> tmp = new Deque<T>(t);
            while (tmp.size() > 0)
            {
                if (tmp.peekAtFront() != null)
                {
                    d.Insert(0, tmp.popFromBack());
                }
            }
        }

        public void addToBack(Deque<T> t)
        {
            Deque<T> tmp = new Deque<T>(t);
            while (tmp.size() > 0)
            {
                d.Add(tmp.popFromFront());
            }
        }

        public void addToBack(T t)
        {
            d.Add(t);
        }

        public T peekAtFront()
        {
            if (d.Count > 0)
                return d[0];
            else
                return default;
        }

        public T peekAtBack()
        {
            if (d.Count > 0)
                return d[d.Count - 1];
            else
                return default;
        }

        public T popFromFront()
        {
            if (d.Count > 0)
            {
                T tmp = d[0];
                d.RemoveAt(0);
                return tmp;
            }
            else
                return default;
        }

        public T popFromBack()
        {
            if (d.Count > 0)
            {
                T tmp = d[d.Count - 1];
                d.RemoveAt(d.Count - 1);
                return tmp;
            }
            else
                return default;
        }

        public string toString()
        {
            string str = "";
            for (int i = 0; i < d.Count; i++)
            {
                str += d[i] + " ";
            }
            return str;
        }
    }
}