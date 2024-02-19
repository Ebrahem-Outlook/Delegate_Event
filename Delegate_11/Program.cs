namespace Delegate_Event
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int[] Values = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            Transform<int>(ref Values, i => i *i, e => e % 2 == 0);

            Transform<int>(ref Values, Square, e => e % 2 == 0);

            foreach (var item in Values)
            {
                Console.WriteLine(item);
            }
        }

        public static void Transform<T>(ref T[] Values, Func<T, T> Square, Predicate<T>Filter)
        {
            for (int i = 0; i < Values.Length; i++)
            {
                if (Filter(Values[i]))
                    Values[i] = Square(Values[i]);
            }
        }

        public static int Square(int x) => x * x;
    }
}