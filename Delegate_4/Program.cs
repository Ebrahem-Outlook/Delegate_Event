
namespace Delegate_Event
{
    public delegate void Report(int percentComplete);
    public class Program
    {
        public static void Main(String[] args)
        {
            Report report = WriteProgressToConsole;
            report += WriteProgressToFile;

            hardWork(report);

        }

        static void WriteProgressToConsole(int report) => Console.WriteLine(report);
        static void WriteProgressToFile(int report) => System.IO.File.WriteAllText("Progress.txt", report.ToString());
         
        public static void hardWork (Report p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10); // Invoke Delegate
                System.Threading.Thread.Sleep(100);
            }
        }
       
      

    }
}