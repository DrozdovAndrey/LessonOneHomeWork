namespace HelloWorld  
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
//             int even;                                      // добвил лишние переменные, можно обойтись без них
//             int odd;
            if (number % 2 == 0)
                {
//                     even = number;
                    Console.WriteLine($"Введенное число - {number} - четное");
                }
            else
                {
//                     odd = number;
                    Console.WriteLine($"Введенное число - {number} - нечетное");
                }    
                
        }  
    }
}
