using System.Diagnostics.Metrics;
using static Delegate_Event.Program;

namespace Delegate_Event
{
    public class Program
    {
        public delegate int CountIt(int end);
        public static void Main(String[] args)
        {
            CountIt count = ClassA.Counter();

            int result = count(10);

            Console.WriteLine(result);
        }

        

    }

    public class ClassA
    {
        public static CountIt Counter()
        {
            int sum = 0;
            // Here a summation of the count is stored in the captured variable sum
            CountIt del = delegate (int end)
            {
                for (int i = 0; i < end; i++)
                {
                    Console.WriteLine(i); ;
                    sum += i;
                }
                return sum;
            };
            return del;
        }
    }
}