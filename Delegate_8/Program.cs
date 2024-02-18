namespace Delegate_Event
{
    public delegate T Del<T>(T x);
    public class Program
    {
        public static void Main(String[] args)
        {

            int[] Values = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            Calculator(Values, Square);

            for (int i = 0; i < Values.Length; i++)
            {
                Console.WriteLine(Values[i]);
            }

        }

        public static void Calculator<T>(T[] Values, Del<T> del)
        {
            for (int i = 0; i < Values.Length; i++)
            {
                Values[i] = del(Values[i]);
            }
        }


        public static int Square(int x) => x * x;

    }



    
}