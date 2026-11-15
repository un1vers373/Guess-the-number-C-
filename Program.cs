
using System;

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

            Console.WriteLine("\nВыберите сложность:");
            Console.WriteLine("1 — Лёгкая (1–50)");
            Console.WriteLine("2 — Средняя (1–100)");
            Console.WriteLine("3 — Сложная (1–500)");
            Console.Write("Ваш выбор: ");

            string difficulty = Console.ReadLine();

            int maxNumber;

            switch (difficulty)
            {
                case "1":
                    maxNumber = 50;
                    break;

                case "2":
                    maxNumber = 100;
                    break;

                case "3":
                    maxNumber = 500;
                    break;

                default:
                    maxNumber = 100;
                    Console.WriteLine("Неверный выбор. Установлена средняя сложность.");
                    break;
            }

            int secretNumber = random.Next(1, maxNumber + 1);
            int attempts = 0;
            bool isGuessed = false;

            Console.WriteLine($"\nЧисло от 1 до {maxNumber}, попробуй угадать его!");

            while (!isGuessed)
            {
                Console.Write("Введите ваше число: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int userGuess))
                {
                    Console.WriteLine("Введите целое число!");
                    continue;
                }

                attempts++;

                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Моё число больше!");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Моё число меньше!");
                }
                else
                {
                    isGuessed = true;
                    Console.WriteLine($"\nХарош! Ты угадал число {secretNumber} за {attempts} попыток!");
                }
            }

            Console.Write("\nХотите сыграть еще раз? (да/нет): ");
            string answer = Console.ReadLine()?.Trim().ToLower();

            if (answer != "да" && answer != "д" && answer != "yes" && answer != "y")
            {
                playAgain = false;
                Console.WriteLine("\nСпасибо за игру, давай связь!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("=============");
                Console.WriteLine("УГАДАЙ ЧИСЛО!");
                Console.WriteLine("=============");
            }
        }
    }
}
