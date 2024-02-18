using System.Collections.Specialized;

namespace Delegate_Event
{
    public delegate int Calculator(int x);
    public class Program
    {
        public static void Main(String[] args)
        {
            Calculator del = Square;

            int[] values = [1, 2, 3, 4];
            Calculate(values, Square);
            Calculate(values, Add);

            // Calculate(values, del);

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }

        public static void Calculate(int[] values, Calculator t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t(values[i]);
        }

        public static int Square(int x) => x * x;
        public static int Add(int x) => x + x;
    }
}