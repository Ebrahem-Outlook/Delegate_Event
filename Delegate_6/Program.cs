namespace Delegate_Event
{
    public class Program
    {
  
        public static void Main(String[] args)
        {
            int[] Values = [1, 2, 3, 4, 5, 6];

            Report(Values, Filter, Square);
            for (int i = 0; i < Values.Length; i++)
            {
                Console.WriteLine(Values[i]);
            }
        }


        public static void Report(int[] values, Func<int, int> del)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = del(values[i]);
            }
        }
        public static void Report(int[] values, Predicate<int> Filter,Func<int, int> del)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (Filter(values[i]))
                {
                    values[i] = del(values[i]);
                }
                
            }
        }


        public static int Square(int x) => x * x;
        public static bool Filter(int x) => (x % 2 == 0) ? true : false;
    }
}