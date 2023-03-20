namespace CodeSignal14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] a= new int[] { 50, 60, 60, 45, 70 };
            program.solution(a);
        }


        int[] solution(int[] a)
        {
            int[] b = new int[2];

            for (int i = 0; i < a.Length; i++)
            {
                if (i%2==0)
                    b[0] = b[0] + a[i];
                else
                    b[1] = b[1] + a[i];
            }

            return b;
        }
    }
}