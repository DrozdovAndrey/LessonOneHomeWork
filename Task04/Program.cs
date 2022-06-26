namespace HelloWorld  
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите третье число: ");
            double number3 = Convert.ToDouble(Console.ReadLine());
            double max;
            if (number1 > number2)
                {
                    max = number1;
                    if (number1 > number3) 
                        {
                            max = number1;
                        }
                    else
                        {
                            max = number3;
                        }
                }
            else 
                {
                    max = number2;
                    if (number2 > number3)
                        {
                            max = number2;
                        }
                    else
                        {
                            max = number3;
                        }
                }
            Console.WriteLine($"Максимальное число: {max}");
        }  
    }
}