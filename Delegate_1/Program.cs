namespace Delegate_Event
{
    // A simple delegate example.

    // declare a delegate
    delegate string StringMethod(string str);
    public class Program
    {
        // Replaces space with hyphens
        public static string ReplaceSpaces(string s)
        {
            Console.WriteLine("Replacing spaces with hyphens::");
            return s.Replace(' ', '_');
        }

        // Remove spaces
        public static string RemoveSpaces(string s)
        {
            string temp = "";
            Console.WriteLine("Remove Space::");
            for (int i = 0; i < s.Length; i++)
                if (s[i] != ' ') temp += s[i];
            return temp;
        }

        // Reverse a string
        public static string Revers(string s)
        {
            string temp = "";
            Console.WriteLine("Reverse String::");
            for (int i = s.Length - 1; i > -1; i--) temp += s[i];
            return temp;
        }


        public static void Main(String[] args)
        {
            // Contruct a delegate
            StringMethod del = new StringMethod(ReplaceSpaces);
            string str;

            str = del("Ebrahem Mohamed Ahemad Ebrahem");
            Console.WriteLine($"Replace space Method :: {str}");


            Console.WriteLine();


            del = new StringMethod(RemoveSpaces);
            str = del("This is a test");
            
            Console.WriteLine($"Remove spaces method:: {str}");


            Console.WriteLine();

            del = new StringMethod(Revers);
            str = del("This is a test");

            Console.WriteLine($"Revers spaces method:: {str}");

        }

    }
}