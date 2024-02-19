
namespace Delegate_Event
{
    public delegate void MyEventHandler();
    public class MyEvent
    {
        public event MyEventHandler My_Event_Handler;

        public void OnMyEvent()
        {
            if(My_Event_Handler != null)
                My_Event_Handler();
        }
    }

    public class X
    {
        private int Id;
        public X(int id)
        {
            Id = id;
        }

        public void MyHandler()
        {
            Console.WriteLine($"Event resived by object :: {Id}");
        }
    }

    public class Y
    {
        public static void MyHandler()
        {
            Console.WriteLine($"Event resived by Class ::");
        }
    }


    public class Program
    {
        public static void Main(String[] args)
        {
            MyEvent myEvent = new MyEvent();
            X O1 = new X(1);
            X O2 = new X(2);
            X O3 = new X(3);

            // subscriberis
            myEvent.My_Event_Handler += O1.MyHandler;
            myEvent.My_Event_Handler += O2.MyHandler;
            myEvent.My_Event_Handler += O3.MyHandler;

            // fire event
            myEvent.OnMyEvent();

            IList<int> list = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            IList<string> employees = ["Ebrahem", "Mohamed", "Ahemad", "Mariam", "Malak", "FatimaEe"];

            Prosses.Report1(list, e => e * e, e => e % 2 == 0);
            IList<string> Answer = Prosses.Report2(employees, (e) => !e.ToLower().Contains('e'));

            foreach (var item in Answer)
            {
                Console.WriteLine(item);
            }
        }


    }


    public class Prosses
    {
        public static void Report1<T>(IList<T> values, Func<T, T> Operation, Predicate<T> Filter)
        {
            foreach (var item in values)
            {
                if (Filter(item)) 
                    Operation(item);
            }
        }

        public static IList<T> Report2<T>(IList<T> Employee, Predicate<T> Filter)
        {
            IList<T> Result = new List<T>();
            foreach (var item in Employee)
            {
                if (Filter(item))
                    Result.Add(item);
            }
            return Result;
        }
    }
}