
namespace Delegate_Event
{
    public delegate string Del(string str);
    public class Program
    {
        public static void Main(String[] args)
        {
            Del del = null;
        
            

        }

        public static void CallDel(Del del)
        {
            Console.WriteLine(del("Hello Wrold"));
     
        }

        // Replace Spaces
        public static string ReplaceSpaces(ref string s)
        {
            Console.WriteLine("Replacing spaces with hyphens:: ");
            return s.Replace(' ', '_');
        }

        // Remove Spaces
        public static string RemoveSpaces(ref string s)
        {
            Console.WriteLine("Remove Spaces ::");

            string temp = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ') temp += s[i];
            }
            return temp;
        }

        // Reverse String 
        public static string Reverse(ref string s)
        {
            Console.WriteLine("Reverse ::");
            string temp = "";
            for (int i = s.Length - 1; i > 0; i--)
            {
                temp += s[i];
            }
            return temp;
        }

    } 
}