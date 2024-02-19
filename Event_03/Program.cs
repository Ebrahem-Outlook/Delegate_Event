// Example
// A very simple event demonstration
namespace Delegate_Event
{
    // declare a delegate type for an event
    public delegate void MyEventHandler();

    // Declare a class this contains an event 
    public class MyEvent
    {
        // Event_Delegate
        public event MyEventHandler My_Event_Handler;

        // This is called to raise the event
        public void OnMyEvent()
        {
            if (My_Event_Handler != null)
                My_Event_Handler();
        }
    }

    public class Program
    {
        // An event handler
        private static void Handler()
        {
            Console.WriteLine("Event occurred");
        }

        public static void Main(String[] args)
        {
            MyEvent Event = new MyEvent();

            // Add Handler() to the event list
            Event.My_Event_Handler += Handler;

            Event.OnMyEvent();

        }
    }
       
}