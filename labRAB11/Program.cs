using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRAB11
{
    class Program
    {
        public void vabad_piletid(int[,]nums)
        {
            for(int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = 0;
                    Console.Write(nums[i, j]);
                }
                Console.WriteLine();
            }
        }
        
        
        
        static void Main(string[] args)
        {
            int[,] nums = new int[4, 7];
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            Program prog = new Program();
            prog.vabad_piletid(nums);
            for (int i = 0; i < texts.GetLength(0); i++)
            {
                for (int j = 0; j < texts.GetLength(1); j++)
                {
                    nums[i, j] = 0;
                    Console.Write();
                }
                do
                {
                    Console.Write("Vali rida: ");
                    int rida = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Vali koht: ");
                    int koht = Convert.ToInt32(Console.ReadLine());
                    if (nums[rida, koht] == 0)
                    {
                        Console.WriteLine("Koht on vaba!");
                        nums[rida, koht] = 1;
                        for (int i = 0; i < nums.GetLength(0); i++)
                        {
                            for (int j = 0; j < nums.GetLength(1); j++)
                            {
                                nums[i, j] = 0;
                                Console.Write(nums[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }
                            }
            }
                string[] texts = new string[4];
            for (int i = 0; i < texts.GetLength(0); i++)
            {
                Console.WriteLine("{0}-text", (i + 1).ToString());
                texts[i] = Console.ReadLine();
            }
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers[1]);
            foreach (int item in numbers) //foreach лужит для циклического обращения к элементам коллекции, 
                                          //представляющей собой группу объектов.

            {

            }
            
            {
                Console.Write(item) + " ";

            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "_");
            Console.WriteLine("Write a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write z");
            int z = Convert.ToInt32(Console.ReadLine());
            double c = (a + b) * (a - 23 * z);
            Console.WriteLine("c={0}", c.ToString());
            
        }
    }
}
