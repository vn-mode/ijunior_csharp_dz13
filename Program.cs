using System;

namespace vn_mode_csharp_dz13
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputName = "SetName";
            string colorConsole = "ChangeConsoleColor";
            string userPassword = "SetPassword";
            string userName = "WriteName";
            string esc = "Esc";
            string defaultName = "Guest";
            string userChangeConsoleColor;
            string defaultPassword = "12345678";
            string userInput;

            while (true)
            {
                Console.WriteLine("Приветствую тебя пользователь.\nСПИСОК ДОСТУПНЫХ КОМАНД ДЛЯ ВВОДА:\n");
                Console.WriteLine($"{userInputName} - устанавливает имя");
                Console.WriteLine($"{colorConsole} - изменяет цвет консоли");
                Console.WriteLine($"{userPassword} - устанавливает пароль");
                Console.WriteLine($"{userName} - выводит имя на экран после ввода пароля");
                Console.WriteLine($"{esc} - вывод из программы\n");
                Console.Write("ВВЕДИТЕ КОМАНДУ: ");
                userInput = Console.ReadLine();

                if (userInput != esc)
                {
                    switch (userInput)
                    {
                        case "SetName":
                            Console.Write("Введите ваше имя: ");
                            defaultName = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Done! Имя успешно добавлено.");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case "ChangeConsoleColor":
                            Console.WriteLine("Выберете желаемый цвет из доступных:\n");
                            Console.WriteLine("Red - изменяет цвет консоли в красный цвет");
                            Console.WriteLine("Black - изменяет цвет консоли в чёрный цвет");
                            Console.WriteLine("Reset - настройки цвета по умолчанию");
                            userChangeConsoleColor = Console.ReadLine();
                            switch (userChangeConsoleColor)
                            {
                                case "Red":
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Done! Цвет консоли успешно изменён.");
                                    break;
                                case "Black":
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.WriteLine("Done! Цвет консоли успешно изменён.");
                                    break;
                                case "Reset":
                                    Console.ResetColor();
                                    Console.WriteLine("Done! Цвет консоли успешно сброшен.");
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Вы ввели не существующую команду.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                            }
                            break;
                        case "SetPassword":
                            Console.WriteLine("Придумайте пароль: ");
                            defaultPassword = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Done! Пароль успешно добавлено.");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case "WriteName":
                            Console.WriteLine("Для вывода имени на экран введите пароль:");
                            userInput = Console.ReadLine();
                            if (userInput == defaultPassword)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Done! Ваше имя: {defaultName}.");
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Вы ввели неверный пароль или пароль не установлен.\nПопробуйте воспользоваться командой SetPassword");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        case "Esc":
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели не существующую команду.");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                    }
                }
                else if (userInput == esc)
                {
                    break;
                }

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ВЫ ВЫШЛИ ИЗ ПРОГРАММЫ.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
