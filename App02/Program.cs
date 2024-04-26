// Додати до попереднього завдання можливість задати фіксовану кількість повторів виконання програми.

using System.Text;

namespace App02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int number;
            int i;
            int end = 0;
            int circle;

            Console.WriteLine("\tМасиви та рядки\n");
            Console.Write("Введіть кількість повторів: ");
            circle = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("\n\tМасив\n");
                Console.Write("Введіть номер кількості чисел: ");
                number = int.Parse(Console.ReadLine());

                int[] nums = new int[number];

                for (i = 0; i < nums.Length; i++)
                {
                    Console.Write("Введіть числа масиву: ");
                    nums[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();

                for (i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Масив [" + i + "]: " + nums[i]);
                }

                end++;
            }
            while (end != circle);
        }
    }
}
