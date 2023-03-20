namespace CodeSignal10
{
    internal class Program
    {
        static void Main(string[] args)
        {

             string s1 = "aabcc";
             string s2 = "adcaa";

            //  s1 = new string(s1.Distinct().ToArray());
            // s2 = new string(s2.Distinct().ToArray());


            //  Console.WriteLine("s1 = "+s1+"   s2 = "+s2);




            int count = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1.ElementAt(i).CompareTo(s2.ElementAt(j)) == 0)
                    {
                        count++;
                        s2 = s2.Remove(j, 1);
                        break;
                    }
                }
            }
            Console.WriteLine(count);

        }
    }
}