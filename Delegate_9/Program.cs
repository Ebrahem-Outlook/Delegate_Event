namespace Delegate_Event
{
    public class Program
    {
        // Declare a genaric delegate.
        delegate T Del<T>(T v);
        public static void Main(String[] args)
        {
            // Construct an int delegate
            Del<int> intdel = Sum;
            Console.WriteLine(intdel(3));

            Del<string> strdel = Reflect;
            Console.WriteLine(strdel("Hello"));

        }

        // return summation of the argument
        public static int Sum(int v)
        {
            int result = 0;
            for (int i = v; i > 0; i--)
                result += i;
            
            return result;
        }

        // return a string containing the reverse of the argument.
        public static string Reflect(string str )
        {
            string result= "";

            foreach (char ch in str)
            {
                result += ch;
            }
            return result;
        }

    }




}