namespace CodeSignal6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] statues = new int[2] { 1, 10 };//4 5 7
            int count2 = 0;

            for (int i = statues.Min(); i < statues.Max()+1; i++)
            {
                count2++;
            }
            Console.WriteLine(count2-statues.Length);

        }
    }
}