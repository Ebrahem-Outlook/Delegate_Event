namespace Delegate_Event
{

    public class Program
    {
        public static void Main(String[] args)
        {
            int[] Values = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            Calculator(Values, i => i % 2 == 0, x => x * x);

            foreach (var item in Values)
            {
                Console.WriteLine(item);
            }
        }

        public static void Calculator<T>(T[] Values, Predicate<T> Filter, Func<T, T> Square)
        {
            for (int i = 0; i < Values.Length; i++)
            {
                if (Filter(Values[i]))
                    Values[i] = Square(Values[i]);
            }
        }

        
    }
}