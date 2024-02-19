// Multicast Event Example
// An event multicast demonstration
using System.Reflection.Metadata;

namespace Delegate_Event
{
    // Declare a delegate type for an event
    public delegate void MyEventHandler();

    // Declare a class that contanis an event
    public class MyEvent
    {
        // Declare Event_Delegate
        public event MyEventHandler My_Event_Handler;

        // This is called to raise the event
        public void OnEvent()
        {
            if(My_Event_Handler != null)
                My_Event_Handler();
        }
    }

    public class X
    {
        public static void XHandler()
        {
            Console.WriteLine("Event recevied by X object.");
        }
    }
    public class Y
    {
        public static void YHandler()
        {
            Console.WriteLine("Event recevied by Y object.");
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            MyEvent myEvent = new MyEvent();
            X xobj = new X();
            Y yobj = new Y();
            // Add Handler to the event list.
            myEvent.My_Event_Handler += MyEvent_My_Event_Handler;
            myEvent.My_Event_Handler += X.XHandler;
            myEvent.My_Event_Handler += Y.YHandler;
            myEvent.My_Event_Handler += MyEvent_My_Event_Handler1;

            // Raise the event 
            myEvent.OnEvent();
            Console.WriteLine();

            // Remove a handler
            myEvent.My_Event_Handler -= MyEvent_My_Event_Handler;
            myEvent.My_Event_Handler -= X.XHandler;
            myEvent.My_Event_Handler -= Y.YHandler;

        }

        private static void MyEvent_My_Event_Handler1()
        {
            Console.WriteLine("New Subscriber");
        }

        private static void MyEvent_My_Event_Handler()
        {
            Console.WriteLine("Event recived by EventDemo");
        }
    }

}