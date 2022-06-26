namespace HelloWorld  
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. (не включая N)

// 5 -> 2, 4
// 8 -> 2, 4, 6

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите число ");
            double number = Convert.ToDouble(Console.ReadLine());
            int odd = 0;
            Console.WriteLine($"Все четные числа от 1 до {number}: ");
            while (odd < number)
                {
                    if (odd % 2 == 0) Console.WriteLine($"{odd}");
                    odd +=2;
                }

                
        }  
    }
}