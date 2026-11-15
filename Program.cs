using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConsoleApp3
{
    static void Main(string[] args)
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        bool playAgain = true;

        Console.WriteLine("=============");
        Console.WriteLine("УГАДАЙ ЧИСЛО!");
        Console.WriteLine("=============");

        while (playAgain)
        {
            Random random = new Random();
            int variable1 = random.Next(1, 101); 
            int variable2 = 0;
            bool variable3 = false;

            Console.WriteLine("\nЧисло от 1 до 100, попробуй угадать его!");

            while (!variable3)
            {
                Console.Write("Введите ваше число: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int variable4))
                {
                    Console.WriteLine("Пожалуйста, введите целое число!");
                    continue;
                }

                variable2++;

                if (variable4 < variable1)
                {
                    Console.WriteLine("Моё число больше! ");
                }
                else if (variable4 > variable1)
                {
                    Console.WriteLine("Моё число меньше! ");
                }
                else
                {
                    variable3 = true;
                    Console.WriteLine($"\n Поздравляю! Ты угадал число {variable1} за {variable2} попыток!");
                }
            }

            Console.Write("\nХотите сыграть еще раз? (да/нет): ");
            string variable5 = Console.ReadLine()?.Trim().ToLower();

            if (variable5 != "да" && variable5 != "д" && variable5 != "yes" && variable5 != "y")
            {
                playAgain = false;
                Console.WriteLine("\nСпасибо за игру, давай связь!");
            }
        }
    }
}