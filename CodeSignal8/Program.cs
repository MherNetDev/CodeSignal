namespace CodeSignal8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[][] myArray = new int[3][];
            myArray[0] = new int[] { 1, 2, 3, 8 };
            myArray[1] = new int[] { 4, 5, 7, 9 };
            myArray[2] = new int[] { 6, 7, 8, 9 };

           // Console.WriteLine(myArray.GetLength(0)); //rows
          //  Console.WriteLine(myArray[0].GetLength(0));//columns

            //int rows = matrix.GetLength(0);
            //int columns = matrix.GetLength(1);

            //1, 1, 1, 0
            //0, 5, 0, 1
            //2, 1, 3, 10

            //0, 1, 1, 2
            //0, 5, 0, 0
            //2, 0, 3, 3
          



            Program program = new Program();
            Console.WriteLine(program.solution(myArray));
        }


        int solution(int[][] matrix)
        {
            int count = 0;
            int rows = matrix.GetLength(0);
            int columns = matrix[0].GetLength(0);

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {

                    if (matrix[j][ i] == 0)
                    {
                        break;
                    }
                    else
                    {
                        count = count + matrix[j][i];
                    }
                }
            }

            return count;

        }

    }
}