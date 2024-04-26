// Додати до попереднього завдання можливість розрахунку
// для обчислення суми усіх введених елементів масиву.

using System.Text;

namespace App03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int number;
            int result = 0;
            int result_all = 0;
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
                    result += nums[i];
                }
                Console.WriteLine();

                for (i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Масив [" + i + "]: " + nums[i]);
                }
                Console.WriteLine("\nРезультат: " + result);
                end++;
            }
            while (end != circle);

            result_all += result;
            Console.WriteLine("\nЗагальний результат: " + result_all);
        }
    }
}
