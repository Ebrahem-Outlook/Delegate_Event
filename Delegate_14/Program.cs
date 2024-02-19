namespace Delegate_Event
{
    public delegate int Del(ref int end);
    public class Program
    {
        public static void Main(String[] args)
        {

            Del del = delegate (ref int end)
            {
                int sum = 0;
                for (int i = 0; i <= end; i++)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                return sum;
            };

            Console.Write("Please Enter A Numbers Of Loop :: ");

            int number;
            number = Convert.ToInt32(Console.ReadLine());

            int result = del(ref number);
            Console.WriteLine($"Result::{result}");

            Console.WriteLine($"Result::{del(ref number)}");
        }

    }
}