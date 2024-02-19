
namespace Delegate_Event
{
    public delegate void ChangeEvent(decimal oldPrice, decimal newPrice);
    public class Program
    {
        public static void Main(String[] args)
        {
            
        }
    }


    public class BroadCastor
    {
        public event ChangeEvent Change;
    }

}