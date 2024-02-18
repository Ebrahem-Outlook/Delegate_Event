
namespace Delegate_Event
{

    public class Program
    {
        // Declare a delegate type.
        delegate void StringMethod(ref string str);
        public static void Main(String[] args)
        {
            // Construct delegates.
            StringMethod strOp;
            StringMethod replaceSp = ReplaceSpaces;
            StringMethod removeSp = RemoveSpaces;
            StringMethod reverseStr = Reverse;
            string str = "This is a test";

            // Set up multicast.
            strOp = replaceSp;
            strOp += reverseStr;

            // Call multicast.
            strOp(ref str);
            Console.WriteLine("Resulting string: " + str);
            Console.WriteLine();

            // Remove replace and add remove.
            strOp -= replaceSp;
            strOp += removeSp;

            str = "This is a test."; // reset string

            // Call multicast.
            strOp(ref str);
            Console.WriteLine("Resulting string: " + str);
            Console.WriteLine();
        }

        // Replaces spaces with hyphens.
        static void ReplaceSpaces(ref string s)
        {
            Console.WriteLine("Replacing spaces with hyphens.");
            s = s.Replace(' ', '-');
        }

        // Remove spaces.
        static void RemoveSpaces(ref string s)
        {
            string temp = "";
            int i;

            Console.WriteLine("Removing spaces.");
            for (i = 0; i < s.Length; i++)
                if (s[i] != ' ') temp += s[i];

            s = temp;
        }

        // Reverse a string.
        static void Reverse(ref string s)
        {
            string temp = "";
            int i, j;
            Console.WriteLine("Reversing string.");

            for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
                temp += s[i];

            s = temp;
        }
    }

        



    
}