namespace HelloWorld  
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите число a: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            double number2 = Convert.ToDouble(Console.ReadLine()); 
            double max; 
            double min; 
            if (number1 == number2) 
            {
                 Console.WriteLine("Эти числа равны!");
            } 
            else
            {
                if (number1 > number2)
                {
                    max = number1;
                    min = number2;

                }
                else
                {
                    max = number2;
                    min = number1;
                }
                Console.WriteLine($"Большее число: {max}, Меньшее число: {min} ");
            }
        }  
    }
}