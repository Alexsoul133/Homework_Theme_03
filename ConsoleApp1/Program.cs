using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)


            // Делаем игру цикличной
            for (; ; )
            {
                int userTry;
                #region переменные игроков               
                // Считывание имён до 8 игроков
                    Console.WriteLine("Игрок1 введи свой никнейм");
                    string user1 = Console.ReadLine();
                    Console.WriteLine("Игрок2 введи свой никнейм");
                    string user2 = Console.ReadLine();
                    Console.WriteLine("Игрок3 введи свой никнейм");
                    string user3 = Console.ReadLine();
                    Console.WriteLine("Игрок4 введи свой никнейм");
                    string user4 = Console.ReadLine();
                    Console.WriteLine("Игрок5 введи свой никнейм");
                    string user5 = Console.ReadLine();
                    Console.WriteLine("Игрок6 введи свой никнейм");
                    string user6 = Console.ReadLine();
                    Console.WriteLine("Игрок7 введи свой никнейм");
                    string user7 = Console.ReadLine();
                    Console.WriteLine("Игрок8 введи свой никнейм");
                    string user8 = Console.ReadLine();
                #endregion

                string currentUser = user1; //первый ходит игрок 1

                // Генерация случайного числа
                Random rand = new Random();
                Console.WriteLine("Настроим сложность.\nВведите нижнюю границу случайного числа");
                int r1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите верхнюю границу случайного числа");
                int r2 = Int32.Parse(Console.ReadLine());
                int gamenumber = rand.Next(r1, r2);

                // Указываем конечное число для победы в игре
                int targetnumber;
                // Считываем пока не будет указано правильное число
                while (true)
                {
                    Console.WriteLine($"Введите число для победы в диапазоне от {r1} до {r2}");
                    targetnumber = Int32.Parse(Console.ReadLine());
                    if (targetnumber < r1 || targetnumber > r2)
                    {
                        Console.WriteLine("Неверное число");
                    }
                    else
                    {
                        break;
                    }
                    
                }
                
                #region Процесс геймплея
                // Начало геймплея, задаём i для подсчета хода игроков
                for (int i = 1; ; i++)
                {
                    Console.WriteLine($"Число: {gamenumber}");
                    // Если игроки получили число меньше целевого числа то игра прекращается
                    if (gamenumber < targetnumber) { Console.WriteLine("Вы проиграли"); break; }

                    // Выбор хода игрока
                    #region Такой способ не подойдёт для количества игроков >2
                    //// Если раунд чётный значит ходит игрок2
                    //if (i % 2 == 0)
                    //{
                    //    currentUser = user2;
                    //}
                    //// Иначе ходит игрок1
                    //else
                    //{
                    //    currentUser = user1;
                    //}
                    #endregion

                    // Выбираем хода в зависимости от хода раунда
                    switch (i)
                    {
                        case 1:
                            currentUser = user1;
                            break;
                        case 2:
                            currentUser = user2;
                            break;
                        case 3:
                            currentUser = user3;
                            break;
                        case 4:
                            currentUser = user4;
                            break;
                        case 5:
                            currentUser = user5;
                            break;
                        case 6:
                            currentUser = user6;
                            break;
                        case 7:
                            currentUser = user7;
                            break;
                        case 8:
                            currentUser = user8;
                            break;
                    }


                    Console.WriteLine($"Ход {currentUser}: ");
                    userTry = Int32.Parse(Console.ReadLine());

                    // По тз нужно разрешить только числа 1,2,3,4
                    if (userTry > 0 && userTry < 5)
                    {
                        gamenumber -= userTry;
                        // Если число равно целевому числу, то объявляем победителя и прерываем цикл
                        if (gamenumber == targetnumber)
                        {
                            Console.WriteLine($"{currentUser} победил");
                            break;
                        }
                        //currentUser++;
                    }
                    else
                    {
                        Console.WriteLine("Неверное число");
                        i--; // откатываем раунд чтобы текущий игрок повторил ход
                    }
                    if (i == 8) { i = 1; } // начинаем новый раунд
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
