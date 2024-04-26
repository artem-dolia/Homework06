// Створити програму яка буде заповнювати масив чисел та виводити їх в консоль.
// При запуску програми користувач вводить кількість чисел в масиві та самі числа.

// hello/

using System.Text;

namespace App01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int number;
            int i;

            Console.WriteLine("\tМасив\n");
            Console.Write("Введіть номер кількості чисел: ");
            number = int.Parse(Console.ReadLine());

            int[] nums = new int [number];

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
        }
    }
}
