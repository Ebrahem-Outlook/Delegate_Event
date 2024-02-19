namespace Delegate_Event
{
    public delegate void Del(long x);
    public class Program
    {
        // Declare a delegate type
        delegate void CountIt();

        public static void Main(String[] args)
        {
            // Here, the code for counting is passed
            // as an anonymus method 
            CountIt Count = delegate
            {
                // this is the block of code passed to the delegate
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(i);
                }
            };

            Del del = delegate(long x)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine(i);
                }
            };

            Count();
            del(10000);
           
        }

    }
}