namespace CodeSignal4
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int[] numbers =  new int[10];
        
            int maxProduct = int.MinValue;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentProduct = numbers[i] * numbers[i + 1];
                if (currentProduct > maxProduct)
                {
                    maxProduct = currentProduct;
                }
            }
            Console.WriteLine("\n\n");

            Console.WriteLine( maxProduct);
            Console.ReadLine();
        }


    
    }
}