namespace CodeSignal7
{

    internal class Program
    {
        public static int count;

        public static int indexint = 0;
        public static bool ret = true;
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] inputArray = new int[] { 10, 2, 3, 4, 6 };
            program.solution(inputArray);


        }

        //bool solution(int[] inputArray)
        //{


        //    int seqlenght = inputArray.Length - 1;
        //    int[] sequence2 = new int[seqlenght];

        //    solutiont(inputArray);

        //    for (int i = 0, y = 0; i < sequence2.Length + 1; i++)
        //    {
        //        if (i != indexint)
        //        {
        //            sequence2[y] = inputArray[i];
        //            y++;
        //        }
        //    }
        //    solutiont(sequence2);




        //    if (count >= 2)
        //    {
        //        Console.WriteLine("false");
        //        return false;
        //    }
        //    else
        //    {
        //        Console.WriteLine("true");
        //        return true;
        //    }
        //}
    bool solution(int[] inputArray)
    {


        int count = 0;
        for (int i = 1; i < inputArray.Length; i++)
        {
            if (inputArray[i] <= inputArray[i - 1])
            {
                count++;
                if (count > 1)
                {
                        Console.WriteLine("false");

                        return false;
                }
                if (i > 1 && inputArray[i] <= inputArray[i - 2] && i < inputArray.Length - 1 && inputArray[i + 1] <= inputArray[i - 1])
                {
                        Console.WriteLine("false");

                        return false;
                }
            }
        }
            Console.WriteLine("true");
        return true;
    }


    //public int solutiont(int[] s)
    //{

    //    for (int i = 1; i < s.Length; i++)
    //    {
    //        if (s[i] <= s[i - 1])
    //        {
    //            indexint = i - 1;
    //            count++;
    //        }
    //    }
    //    return count;
    //}

}


}
