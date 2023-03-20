namespace CodeSignal8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[,] someint = {
            { 1, 1, 1, 0},//9
            { 0, 5, 0, 1},
            { 2, 1, 3, 10}};
            int[] collectArr = new int[someint.GetLength(1)];
     
            for (int erkar = 0; erkar < someint.GetLength(1); erkar++)//4 erkar
            {
             
                for (int boy = 0; boy < someint.GetLength(0); boy++)//3 boy
                {
                    if (someint[boy, erkar] ==0 )
                    {
                        for (int k = erkar; k < someint.GetLength(1); k++)
                        {
                            Console.WriteLine(someint[erkar,k ]);
                        }

                    }

                }
            }
            //for (int i = 0; i < someint.GetLength(1); i++)
            //{
            //    for (int j = 0; j < someint.GetLength(0); j++)
            //    {
            //        Console.WriteLine(someint[j, i]);

            //    }
            //}

            //for (int i = 0; i < someint.GetLength(1); i++)//4 erkar
            //{

            //    for (int j = 0; j < someint.GetLength(0); j++)//3 boy
            //    {

            //        count = count + someint[j, i];

            //    }
            //}
            // Console.WriteLine(count);
        }
    }
}