namespace CodeSignal12
{
    internal class Program
    {
     

            static void Main(string[] args)
            {
            int[] a = { 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > -1)
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (a[j] != -1 && a[i] < a[j])
                        {
                            int k = a[i];
                            a[i] = a[j];
                            a[j] = k;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(", ", a));



        }



    }
}