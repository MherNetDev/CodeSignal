using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Tests
{
    internal class Program
    {
        public int[] arr = new int[10];

        static void Main(string[] args)
        {
            Program program = new Program();
            for (int i = 0; i < 1; i++)
            {
               
                program.testw();
            }
         






        }
        public void testw() {

            for (int i = 0; i < arr.Length; i++)
            {
                Random random = new Random();
                arr[i] = random.Next(-30,30);
                Console.WriteLine(arr[i]);
            }

        }
    }


}