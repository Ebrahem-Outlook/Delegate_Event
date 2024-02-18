namespace Delegate_Event
{
    public class Program
    {
        public static void Main(String[] args)
        {
            
            Worker c = new Worker();
            Action<int> P = c.work;

            P(99);
            Console.WriteLine(P.Target);
            Console.WriteLine(P.Method);
            
        }

         


    }

    public class Worker
    {
        public void work(int percentCompelete) => System.Console.WriteLine(percentCompelete);
    }
}