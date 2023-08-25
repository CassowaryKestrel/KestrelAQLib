namespace KestrelAQLib
{
    /// <summary>
    /// Wrapper class to emulate passing by reference with C# 9 and Unity
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Ref<T>
    {
        public T Value { get; set; }

        public Ref(T Value)
        {
            this.Value = Value;
        }
    }
}