namespace KestrelAQLib
{
    public class ArrayNegative<T>
    {
        public List<T> arr_positive;
        public List<T> arr_negative;

        public ArrayNegative()
        {
            arr_positive = new List<T>();
            arr_negative = new List<T>();
        }

        public T get(int index)
        {
            if (index < 0)
            {
                if (arr_negative.Count <= -index)
                    return default;
                else
                    return arr_negative[-index];
            }
            else
            {
                if (arr_positive.Count <= index)
                    return default;
                else
                    return arr_positive[index];
            }
        }

        public void set(int index, T t)
        {
            if (index < 0)
            {
                index = -index;
                while (arr_negative.Count <= index)
                {
                    arr_negative.Add(default);
                }
                arr_negative[index] = t;
                return;
            }
            else
            {
                while (arr_positive.Count <= index)
                {
                    arr_positive.Add(default);
                }
                arr_positive[index] = t;
                return;
            }
        }
    }
}