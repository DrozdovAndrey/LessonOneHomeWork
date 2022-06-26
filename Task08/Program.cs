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
            Console.WriteLine("Введите число от 1: ");
            double number = Convert.ToDouble(Console.ReadLine());
            int odd = 1;
            if (number < 1)
                {
                    Console.WriteLine("Введено некорректное значение! Повторите ввод от 1!");
                }
            else
                {
                    Console.WriteLine($"Все четные числа от 1 до {number} (не включая {number}): ");
                    while (odd < number)
                    {
                        if (odd % 2 == 0)  Console.WriteLine($"{odd}");
                        odd +=1;     
                    }
                    if (odd == 1) Console.WriteLine("В этом дапозоне нет четных чисел! Введите другое число!");
                    if (odd == 2) Console.WriteLine("В этом дапозоне нет четных чисел! Введите другое число!");

                }
            
                
        }  
    }
}