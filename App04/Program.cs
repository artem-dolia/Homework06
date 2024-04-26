// Розробити консольну програму, яка б сортувала введений масив чисел
// із консолі за зростанням після чого виводила його на екран.

using System.Text;

namespace App04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int number;
            int i;
            int sort;

            Console.WriteLine("\tМасив\n");
            Console.Write("Введіть номер кількості чисел: ");
            number = int.Parse(Console.ReadLine());

            int[] nums = new int[number];

            for (i = 0; i < nums.Length; i++)
            {
                Console.Write("Введіть числа масиву: ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        sort = nums[i];
                        nums[i] = nums[j];
                        nums[j] = sort;
                    }
                }
            }
            Console.WriteLine("\nВідсортований масив:");

            for (i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Масив [" + i + "]: " + nums[i]);
            }
        }
    }
}
