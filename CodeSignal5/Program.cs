namespace CodeSignal5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = Convert.ToInt16(Console.ReadLine());
            int curretn = 0;
         
            for (int i = 0; i < val; i++)
            {

                curretn = curretn+i;
            }
            Console.WriteLine(curretn*4+1);

        }
    }
}