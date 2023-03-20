namespace CodeSignal9
{
    internal class Program
    {
        public static int y=0;
        static void Main(string[] args)
        {
            string[] inputArray = new string[]{"young","yooooooung","hot","or","not","come","on","fire","water","watermelon"};

            Program program = new Program();
            program.solution(inputArray);
        }

        string[] solution(string[] inputArray)
        {

            int y = 0, count = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (count <= inputArray[i].Length)
                    count = inputArray[i].Length;
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length == count)
                {
                    inputArray[y] = inputArray[i];
                    y++;
                }
            }
            Array.Resize(ref inputArray, y);


            return inputArray;
        }




    }
}