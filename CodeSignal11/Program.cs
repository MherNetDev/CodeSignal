using static System.Net.Mime.MediaTypeNames;

namespace CodeSignal11
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n = 134008;
            string s1;
            string s2;

            s1 = Convert.ToString(n);
            s1 = s1.Substring(0, s1.Length/2);

            s2 = Convert.ToString(n);
            s2 = s2.Substring(s2.Length / 2);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            int n1 = 0; int n2 = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                n1 = n1 + Convert.ToInt32(s1[i]);
            }
            for (int i = 0; i < s2.Length; i++)
            {
                n2 = n2 + Convert.ToInt32(s2[i]);
            }

            if (Convert.ToInt16(n1) == Convert.ToInt16(n2))
            {
                Console.WriteLine("true");
            }

            else Console.WriteLine("false");

        }
    }
}