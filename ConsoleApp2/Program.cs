using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером

            // Делаем игру цикличной
            for (; ; )
            {
                int userTry;
                // Считывание имён игроков
                Console.WriteLine("Игрок1 введи свой никнейм");
                string user1 = Console.ReadLine();
                string user2 = "Компьютер";

                // Генерация случайного числа от 12 до 120
                Random rand = new Random();
                int gamenumber = rand.Next(12, 121);

                #region Процесс геймплея
                // Начало геймплея, задаём i для подсчета раундов
                for (int i = 1; ; i++)
                {
                    Console.WriteLine($"Число: {gamenumber}");
                    // Если игроки получили число меньше 0 то игра прекращается
                    if (gamenumber < 0) { Console.WriteLine("Вы проиграли"); break; }

                    // Если раунд чётный значит ходит игрок2
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"Ход {user2}: ");

                        // По тз нужно разрешить только числа 1,2,3,4
                        Random rand2 = new Random();
                        int compNumber = rand2.Next(1, 3);
                            gamenumber -= compNumber;
                            // Если число стало 0, то объявляем победителя и заканчиваем игру
                            if (gamenumber == 0)
                            {
                                Console.WriteLine($"Компьютер победил");
                                break;
                            }
                        } 

                    
                    // Иначе ходит игрок1
                    else
                    {
                        
                        Console.WriteLine($"Ход {user1}: ");
                        userTry = Int32.Parse(Console.ReadLine());

                        // По тз нужно разрешить только числа 1,2,3,4
                        if (userTry > 0 && userTry < 5)
                        {

                            
                            gamenumber -= userTry;
                            // Если число стало 0, тообъявляем победителя и заканчиваем игру
                            if (gamenumber == 0)
                            {
                                Console.WriteLine($"{user1} победил");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Неверное число");
                            i--; // откатываем раунд чтобы текущий игрок повторил ход
                        }
                    }
                    
                }
                #endregion


                Console.WriteLine("Хотите реванш? (да/нет)");
                string revenge; // Заранее объявляем переменную чтобы прочитать её вне цикла              
                while (true) // Считываем ответ пока не получим правильный вариант
                {
                    revenge = Console.ReadLine();
                    if (revenge == "да" || revenge == "нет") break;  //прерываем цикл только когда получим правильный ответ
                }
                Console.Clear();
                if (revenge == "нет") break; // выходим из игры
            }
        }
    }
}
